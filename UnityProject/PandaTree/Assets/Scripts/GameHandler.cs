using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {
    public GameObject player;
    public GameObject inventoryPanel;
    private List<Season> seasons = new List<Season>{
            new Winter(),
            new Spring(),
            new Summer(),
            new Autumn()
        };
    private int currentSeasonCount;

    private MainPlayerScript PlayerMain { get { return this.player.GetComponent<MainPlayerScript>(); } }
    private PanelInventoryHandler InventoryPanelMain { get { return this.inventoryPanel.GetComponent<PanelInventoryHandler>(); } }

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
        this.PlayerMain.AddItemToInventory(new Apple());

        this.InventoryPanelMain.UpdateInventory(this.PlayerMain.Inventory);
    }
}
