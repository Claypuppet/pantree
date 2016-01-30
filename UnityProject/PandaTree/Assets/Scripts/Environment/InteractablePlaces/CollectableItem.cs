using UnityEngine;
using System.Collections;

public abstract class CollectableItem : InteractablePlace
{

    protected Item item;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void interact() {
        // Add item to player inventory
    }
}
