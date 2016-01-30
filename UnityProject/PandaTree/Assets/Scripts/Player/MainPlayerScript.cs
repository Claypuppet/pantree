using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MainPlayerScript : MonoBehaviour {

    private List<Item> inventory;
    private List<Item> offered;
    private int lifeEnergy;

	// Use this for initialization
	void Start () {
        this.inventory = new List<Item>();
        this.offered = new List<Item>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}