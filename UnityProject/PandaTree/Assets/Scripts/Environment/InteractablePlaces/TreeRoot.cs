﻿using UnityEngine;
using System.Collections;

public class TreeRoot : InteractablePlace {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void Interact() {
        Debug.Log("MAKE OFFER");
        this._GameHandler.Player.MakeOffer();
        this._GameHandler.UpdateCanvasInventory();
    }
}
