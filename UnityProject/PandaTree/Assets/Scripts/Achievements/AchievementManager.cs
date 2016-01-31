using UnityEngine;
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

    public TextAsset definitions;

    private float lastSaveTime = 0;
    private bool saveRequired = false;

    // Use this for initialization
    void Start () {

        // Load achivements definitions from XML file.
        LoadDefinitions();

        // Load progress from XML file.
        LoadProgressions();
    }
	
	// Update is called once per frame
	void Update () {
        if(saveRequired && (Time.time - lastSaveTime) >= 10)
            SaveProgress();
	}

    void OnApplicationQuit() {
        if(saveRequired)
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

        saveRequired = false;
    }

    public void OnProgressed(Achievement achievement, AchievementProgress progress, AchievementDefinition.Value value) {
        saveRequired = true;
    }

    public void OnAchieved(Achievement achievement, AchievementProgress progress) {
        saveRequired = true;
    }
}
