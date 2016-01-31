using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    private PlayerMovement PlayerMovement { get { return this.player.GetComponent<PlayerMovement>(); } }
    private PanelInventoryHandler InventoryPanel { get { return this.inventoryPanel.GetComponent<PanelInventoryHandler>(); } }
    private PanelSeasonHandler SeasonPanel { get { return this.seasonPanel.GetComponent<PanelSeasonHandler>(); } }

	// Use this for initialization
    void Start() {
        this.currentSeasonCount = 0;
        Season.StartTimer(1000, ChangeSeason);
	}
	
	// Update is called once per frame
    void Update() {

        // Test inventory
        if (Input.GetKeyDown("space"))
            this.UpdateCanvasInventory();
	}
    
	// Application end
    void OnApplicationQuit() {
        Season.StopTimer();
    }

    private void ChangeSeason() {
        this.currentSeasonCount++;
        Season newSeason = seasons[currentSeasonCount % seasons.Count];
        Debug.Log("Season changed to: " + newSeason.name);

        // TODO: Send season to gameobjects to change stuff
        // 
        //

		reloadGameLevel ();

        int seasonDuration = newSeason.GetSeasonDuration() / 10; 
        Season.StartTimer(seasonDuration, ChangeSeason);
    }

    private void UpdateCanvasInventory() {
        // Add apple to inventory just for testing
        this.Player.AddItemToInventory(new Apple());

        this.InventoryPanel.UpdateInventory(this.Player.Inventory);
    }

    private void UpdateCanvasSeason() {
        //this.SeasonPanel.UpdateInventory(this.Player.Inventory);
    }

    public void MovePlayer(float rad) {
        this.PlayerMovement.MovePlayer(rad, 1);
    }
		
	public void reloadGameLevel(){
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
