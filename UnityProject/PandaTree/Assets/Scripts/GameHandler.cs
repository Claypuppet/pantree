using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {
    public GameObject player;
    public GameObject inventoryPanel;

    private MainPlayerScript Player { get { return this.player.GetComponent<MainPlayerScript>(); } }

	// Use this for initialization
    void Start() {
	}
	
	// Update is called once per frame
    void Update() {

        // Test
        if (Input.GetKeyDown("space"))
            this.updateCanvasInventory();
	}

    public void updateCanvasInventory() {
        // Add apple to inventory just for testing
        this.Player.AddItemToInventory(new Apple());

        this.inventoryPanel.GetComponent<PanelInventoryHandler>().UpdateInventory(this.Player.Inventory);
    }
}
