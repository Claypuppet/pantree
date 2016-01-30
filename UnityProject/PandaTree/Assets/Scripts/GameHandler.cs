﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {
    public GameObject player;
    public GameObject inventoryPanel;
    public GameObject seasonPanel;
    private List<Season> seasons = new List<Season>{
            new Winter(),
            new Spring(),
            new Summer(),
            new Autumn()
        };
    private int currentSeasonCount;

    private MainPlayerScript Player { get { return this.player.GetComponent<MainPlayerScript>(); } }
    private PanelInventoryHandler InventoryPanel { get { return this.inventoryPanel.GetComponent<PanelInventoryHandler>(); } }
    private PanelInventoryHandler SeasonPanel { get { return this.seasonPanel.GetComponent<PanelInventoryHandler>(); } }

	// Use this for initialization
    void Start() {
        this.currentSeasonCount = 0;
        Season.StartTimer(1000, ChangeSeason);
	}

    private void ChangeSeason() {
        this.currentSeasonCount++;
        Season newSeason = seasons[currentSeasonCount % seasons.Count];
        Debug.Log("Season changed to: " + newSeason.name);

        // TODO: Send season to gameobjects to change stuff
        // 
        //

        int seasonDuration = newSeason.GetSeasonDuration() / 10; 
        Season.StartTimer(seasonDuration, ChangeSeason);
    }
	
	// Update is called once per frame
    void Update() {

        // Test inventory
        if (Input.GetKeyDown("space"))
            this.updateCanvasInventory();
	}

    public void updateCanvasInventory() {
        // Add apple to inventory just for testing
        this.Player.AddItemToInventory(new Apple());

        this.InventoryPanel.UpdateInventory(this.Player.Inventory);
    }
}
