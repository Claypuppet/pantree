using UnityEngine;
using System.Collections;

public abstract class Eatable : Item{

    protected bool isEatable = true; 
    protected int restoreAmount; // Amount of life energy the food restores

    public bool IsEatable { get { return this.isEatable; } }
    public int RestoreAmount { get { return this.restoreAmount; } }

}
