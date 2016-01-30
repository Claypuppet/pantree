using UnityEngine;
using System.Collections;

public abstract class Item {

    protected int itemOfferScore;
    protected string name;

    public int ItemOfferScore { get { return this.itemOfferScore; } }
    public string Name { get { return this.name; } }
    
}
