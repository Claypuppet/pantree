using UnityEngine;
using System.Collections;

public class Eatable : Item{

    protected bool eatable = true; 
    protected int restoreAmount; // Amount of life energy the food restores

    public bool Eatable { get { return this.eatable; } }
    public int RestoreAmount { get { return this.restoreAmount; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
