using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameHandler : MonoBehaviour {
    private GameObject player;

    public MainPlayerScript Player { get { return this.player.GetComponent<MainPlayerScript>(); } }

	// Use this for initialization
    void Start() {
        this.player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void updateCanvasInventory() {
        //this.Player.Inventory
    }
}
