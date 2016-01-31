using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameHandler : MonoBehaviour {
    public GameObject player;
    public GameObject inventoryPanel;
    public GameObject seasonPanel;
    public GameObject spawnHandler;

    private bool newSpawnReady = false;
    private List<Season> seasons = new List<Season>{
            new Winter(),
            new Spring(),
            new Summer(),
            new Autumn()
        };
    private int currentSeasonCount;

    public MainPlayerScript Player { get { return this.player.GetComponent<MainPlayerScript>(); } }
    private PlayerMovement PlayerMovement { get { return this.player.GetComponent<PlayerMovement>(); } }
    private PanelInventoryHandler InventoryPanel { get { return this.inventoryPanel.GetComponent<PanelInventoryHandler>(); } }
    private PanelSeasonHandler SeasonPanel { get { return this.seasonPanel.GetComponent<PanelSeasonHandler>(); } }
    private SpawnCollectables SpawnHandler { get { return this.spawnHandler.GetComponent<SpawnCollectables>(); } }

	// Use this for initialization
    void Start() {
        this.currentSeasonCount = 0;
        Season.StartTimer(1000, ChangeSeason);
        SpawnCollectables.SetCallback(TimeToCreateItem);
        SpawnCollectables.StartTimer();
	}
	
	// Update is called once per frame
    void Update() {

        // Test inventory
        if (Input.GetKeyDown("space"))
            this.TimeToCreateItem();

        if (newSpawnReady) {
            Debug.Log("create");
            newSpawnReady = false;
            this.CreateItem();
        }
	}
    
	// Application end
    void OnApplicationQuit() {
        Season.StopTimer();
        SpawnCollectables.StopTimer();
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

    public void TimeToCreateItem() {
        Debug.Log("lol");
        this.newSpawnReady = true;
    }

    public void CreateItem() {
        ItemSpawn newSpawn = this.SpawnHandler.newSpawn();
        if (newSpawn != null)
            Instantiate(newSpawn.itemPrefab, newSpawn.position, Quaternion.identity);
    }

    public void SpawnReady(Vector3 pos) {
        this.SpawnHandler.ResetSpawn(pos);
    }

    public void UpdateCanvasInventory() {
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

	public void initMusic(){
		//Camera.main.
	}
}
