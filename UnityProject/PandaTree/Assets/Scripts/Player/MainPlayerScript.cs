using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MainPlayerScript : MonoBehaviour {

    private List<Item> inventory;
    private List<Item> offered;
    private int lifeEnergy;
    private int score;

    public List<Item> Inventory { get { return this.inventory; } }
    public List<Item> Offered { get { return this.offered; } }
    public int LifeEnergy { get { return this.lifeEnergy; } }
    public int Score { get { return this.score; } }

	// Use this for initialization
	void Start () {
        this.inventory = new List<Item>();
        this.offered = new List<Item>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddScore(int amount) {
        // Add score 
        this.score += amount;
    }

    public void AddItemToInventory(Item item) {
        // Add an item to your inventory
        this.inventory.Add(item);
    }

    public void RemoveItemFromInventory(Item item) {
        // Remove an item from your inventory
        this.inventory.Remove(item);
    }

    public void MakeOffer() {
        // Remove all items from inventory and move it to offered
        Debug.Log("count: " + this.inventory.Count);
        foreach (Item item in this.inventory) {
            this.offered.Add(item);
        }
        this.inventory.RemoveRange(0,this.inventory.Count);
    }

    public void Eat(Edible food) {
         // Can only eat from storage, so dont need to remove from inventory
        this.lifeEnergy += food.RestoreAmount;
    }

    
}