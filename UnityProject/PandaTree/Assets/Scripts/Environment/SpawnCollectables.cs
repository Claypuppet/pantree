using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System;

public class SpawnCollectables : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject gameHandler;
    private List<ItemSpawn> spawnpoints;

    void Start() {
        this.spawnpoints = new List<ItemSpawn>();
        ItemSpawn.prefabs = new List<GameObject>(){
            a,b,c,d,e
        };
        foreach (Transform child in transform) {
            this.spawnpoints.Add(new ItemSpawn(child.transform.position));
        }
    }

    public ItemSpawn newSpawn() {
        List<ItemSpawn> available = spawnpoints.Where(spawn => spawn.isTaken == false).ToList();
        if (available.Count <= 0)
            return null;
        ItemSpawn n = available[new System.Random().Next(0, available.Count - 1)];
        n.isTaken = true;
        n.GetRandomPrefab();
        return n;
    }

    public void ResetSpawn(Vector3 pos) {
        this.spawnpoints.Where(sp => sp.position == pos).ToList()[0].Clear();
    }

    //static stuff for timer
    private static Timer timer;
    private static Action callback;

    public static void StartTimer() {
        timer = new Timer(new System.Random().Next(2000, 5000));
        timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        timer.Start();
    }
    public static void SetCallback(Action cb) {
        callback = cb;
    }
    public static void StopTimer() {
        if (timer.Enabled)
            timer.Stop();
        timer.Dispose();
    }

    private static void OnTimedEvent(object source, ElapsedEventArgs e) {
        StopTimer();
        callback();
        StartTimer();
    }
}

public class ItemSpawn
{
    public static List<GameObject> prefabs = new List<GameObject>();
    public bool isTaken = false;
    public Vector3 position;
    public GameObject itemPrefab;

    public ItemSpawn(Vector3 pos) {
        this.position = pos;
    }

    public void GetRandomPrefab(){
        this.itemPrefab = ItemSpawn.prefabs[new System.Random().Next(0, ItemSpawn.prefabs.Count - 1)];
    }

    public void Clear() {
        this.isTaken = false;
    }
}
