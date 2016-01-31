using UnityEngine;
using System.Collections;

public class CollectableItem : InteractablePlace
{
    protected Item item;

	// Use this for initialization
	void Start () {

        this.gameHandler = GameObject.Find("GameHandler");

        switch (this.gameObject.name) {
            case "Apple" + "(Clone)":
                this.item = new Apple();
                break;
            case "Banana" + "(Clone)":
                this.item = new Banana();
                break;
            case "DragonEgg" + "(Clone)":
                this.item = new DragonEgg();
                break;
            case "Leaf" + "(Clone)":
                this.item = new Leaf();
                break;
            case "Water" + "(Clone)":
                this.item = new Water();
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Interact() {
        Debug.Log("interact");
        // Add item to player inventory
        _GameHandler.Player.AddItemToInventory(this.item);
        _GameHandler.SpawnReady(this.transform.position);
        _GameHandler.UpdateCanvasInventory();
        Destroy(this.gameObject);
        Debug.Log("destoyed object!");
    }
}
