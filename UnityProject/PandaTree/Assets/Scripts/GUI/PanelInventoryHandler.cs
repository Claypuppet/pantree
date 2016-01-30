using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public class PanelInventoryHandler : MonoBehaviour {


	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void UpdateInventory(List<Item> inv) {
        // So quick and dirty ;)
        this.SetAmountText("Apple", inv.Count(item => item.name == "Apple"));
        this.SetAmountText("Banana", inv.Count(item => item.name == "Banana"));
        this.SetAmountText("DragonEgg", inv.Count(item => item.name == "DragonEgg"));
        this.SetAmountText("Leaf", inv.Count(item => item.name == "Leaf"));
        this.SetAmountText("Water", inv.Count(item => item.name == "Water"));
    }

    private void SetAmountText(string objectName, int amount) {
        GameObject.Find(objectName).GetComponent<InventoryItemDelegate>().SetText(amount.ToString());
    }
}
