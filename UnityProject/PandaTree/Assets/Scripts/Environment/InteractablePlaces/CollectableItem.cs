using UnityEngine;
using System.Collections;

public class CollectableItem : InteractablePlace
{
    protected Item item;

	// Use this for initialization
	void Start () {
        switch (this.gameObject.name) {
            case "Apple":
                this.item = new Apple();
                break;
            case "Banana":
                this.item = new Banana();
                break;
            case "DragonEgg":
                this.item = new DragonEgg();
                break;
            case "Leaf":
                this.item = new Leaf();
                break;
            case "Water":
                this.item = new Water();
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Interact() {
        // Add item to player inventory
        _GameHandler.Player.AddItemToInventory(this.item);
        _GameHandler.UpdateCanvasInventory();
        Destroy(this.gameObject);
    }
}
