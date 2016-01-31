using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SpawnCollectables : MonoBehaviour {

    public GameObject gameHandler;
    private List<SpawnPoint> spawnpoints;

    void Start() {
        this.spawnpoints = new List<SpawnPoint>();
        foreach (Transform child in transform) {
            this.spawnpoints.Add(new SpawnPoint(child.transform.position));
        }
    }

    public SpawnPoint newSpawn() {
        List<SpawnPoint> available = spawnpoints.Where(spawn => spawn.isTaken == false).ToList();
        if (available.Count <= 0)
            return null;
        SpawnPoint n = available[new System.Random().Next(0, available.Count)];
        n.isTaken = true;
        return n;
    }
}

public class SpawnPoint
{
    public bool isTaken = false;
    public Vector3 position;
    public Item item;

    public SpawnPoint(Vector3 pos) {
        this.position = pos;
    }

    public Item GetRandomItem(){
        Item item;

        // Randomly decided by the die
        item = new Apple();

        return item;
    }

    public void Clear() {
        this.item = null;
        this.isTaken = false;
    }
}
