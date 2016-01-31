using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System;
using System.Linq;

public class AchievementManager : MonoBehaviour {

    public static string PROGRESSIONS_FILE = "achievement_progressions.xml";
    protected Dictionary<string, AchievementDefinition> mAchievementDefinitions = new Dictionary<string, AchievementDefinition>();
    protected Dictionary<string, AchievementProgress> mAchievementProgressions = new Dictionary<string, AchievementProgress>();
    protected Dictionary<string, Achievement> mAchievements = new Dictionary<string, Achievement>();
    protected LinkedList<Achievement> mAchievedList = new LinkedList<Achievement>();

    public TextAsset definitions;

    private float mLastSaveTime = 0;
    private bool mSaveRequired = false;

    public GameObject achievementTextElement;
    private float mOnScreenTime = 0;
    private bool mOnScreenFadeStarted = false;
    protected Achievement mOnScreen = null;

    public AudioSource audioSource;
    public AudioClip achievedSound;


    // Use this for initialization
    void Start () {

        // Load achivements definitions from XML file.
        LoadDefinitions();

        // Load progress from XML file.
        LoadProgressions();

        if(achievementTextElement == null)
            achievementTextElement = GameObject.Find("AchievementText");
        if(achievementTextElement != null)
            achievementTextElement.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        // Saving should probably go in another thread....
        if(mSaveRequired && (Time.time - mLastSaveTime) >= 15)
            SaveProgress();

        if(mOnScreen != null) {
            var text = achievementTextElement.GetComponent<Text>();
            if(!mOnScreenFadeStarted) {
                if(Time.time - mOnScreenTime >= 5) {
                    mOnScreenFadeStarted = true;
                    text.CrossFadeAlpha(0, 0.5f, false);
                }
            }
            else if(text.canvasRenderer.GetColor().a < 0.001f) {
                mOnScreen = null;
                mOnScreenTime = Time.time;
                achievementTextElement.SetActive(false);
            }
        }

        // Need to show achieved text?
        if(mOnScreen == null && mAchievedList.Count > 0 && Time.time - mOnScreenTime >= 1) {
            mOnScreen = mAchievedList.First();
            mAchievedList.RemoveFirst();
            mOnScreenTime = Time.time;
            mOnScreenFadeStarted = false;

            var text = achievementTextElement.GetComponent<Text>();
            text.text = string.Format("Achieved!\n\n{0}\n{1}", mOnScreen.Name, mOnScreen.Description);
            achievementTextElement.SetActive(true);

            if(audioSource && achievedSound)
                audioSource.PlayOneShot(achievedSound);
        }
	}

    void OnApplicationQuit() {
        if(mSaveRequired)
            SaveProgress();
    }

    void LoadDefinitions() {
        var serializer = new XmlSerializer(typeof(AchievementDefinitions));
        using(var stream = new MemoryStream(definitions.bytes)) {
            var achievementDefinitions = serializer.Deserialize(stream) as AchievementDefinitions;
            foreach(AchievementDefinition def in achievementDefinitions.Definitions) {
                Debug.Log(string.Format("Adding def with id: {0} def: {1}", def.Id, def));
                mAchievementDefinitions.Add(def.Id, def);
            }
        }
    }

    void LoadProgressions() {
        var path = Application.persistentDataPath + "/" + PROGRESSIONS_FILE;
        if(!File.Exists(path))
            return;

        var serializer = new XmlSerializer(typeof(AchievementProgressions));
        using(var stream = new FileStream(path, FileMode.Open)) {
            var progressions = serializer.Deserialize(stream) as AchievementProgressions;
            foreach(AchievementProgress progress in progressions.Progressions) {
                Debug.Log(string.Format("Adding progres with id: {0}", progress.Id));
                mAchievementProgressions.Add(progress.Id, progress);
            }
        }
    }

    void SaveProgress() {
        var path = Application.persistentDataPath + "/" + PROGRESSIONS_FILE;
        var serializer = new XmlSerializer(typeof(AchievementProgressions));

        AchievementProgressions progressions = new AchievementProgressions();
        
        // Select only the progressions with actual values
        var query = from progession in mAchievementProgressions.Values
                    where progession.Values != null && progession.Values.Count > 0
                    select progession;
        progressions.Progressions = query.ToList();

        if(progressions.Progressions.Count > 0) {
            using(var stream = new FileStream(path, FileMode.CreateNew)) {
                serializer.Serialize(stream, progressions);
            }
        }

        mSaveRequired = false;
    }

    public void OnProgressed(Achievement achievement, AchievementProgress progress, AchievementDefinition.Value value) {
        mSaveRequired = true;
    }

    public void OnAchieved(Achievement achievement, AchievementProgress progress) {
        mAchievedList.AddLast(achievement);
        mSaveRequired = true;
    }

    public Achievement GetAchievement(string id) {
        Achievement result;
        if(mAchievements.TryGetValue(id, out result))
            return result;

        AchievementDefinition def;
        if(mAchievementDefinitions.TryGetValue(id, out def)) {
            AchievementProgress progress;
            if(!mAchievementProgressions.TryGetValue(id, out progress)) {
                progress = new AchievementProgress();
                progress.Id = def.Id;
                mAchievementProgressions.Add(id, progress);
            }

            result = new Achievement(this, def, progress);
            if(result != null)
                mAchievements.Add(id, result);
        }
        return result;
    }
}
