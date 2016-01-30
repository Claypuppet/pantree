using UnityEngine;
using System.Collections;

public abstract class Edible : Item{

    protected bool isEdible = true; 
    protected int restoreAmount; // Amount of life energy the food restores

    public bool IsEdible { get { return this.isEdible; } }
    public int RestoreAmount { get { return this.restoreAmount; } }

}
