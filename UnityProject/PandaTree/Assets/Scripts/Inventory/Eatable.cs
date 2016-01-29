using UnityEngine;
using System.Collections;

public class Eatable : Item{

    protected bool isEatable = true; 
    protected int restoreAmount; // Amount of life energy the food restores

    public bool IsEatable { get { return this.isEatable; } }
    public int RestoreAmount { get { return this.restoreAmount; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
