using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MainPlayerScript : MonoBehaviour {

    private List<Item> inventory;
    private List<Item> offered;
    private int lifeEnergy;
    private int score;

    public List<Item> Inventory { get { return this.inventory; } }
    public List<Item> Offered { get { return this.offered; } }
    public int LifeEnergy { get { return this.lifeEnergy; } }
    public int Score { get { return this.score; } }

	// Use this for initialization
	void Start () {
        this.inventory = new List<Item>();
        this.offered = new List<Item>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}