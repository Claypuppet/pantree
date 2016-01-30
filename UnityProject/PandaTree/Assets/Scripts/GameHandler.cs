using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameHandler : MonoBehaviour {
    public GameObject player;
    public GameObject inventoryPanel;

    private MainPlayerScript Player { get { return this.player.GetComponent<MainPlayerScript>(); } }

	// Use this for initialization
    void Start() {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void updateCanvasInventory() {
        this.Player.AddItemToInventory(new Apple());

    }
}
