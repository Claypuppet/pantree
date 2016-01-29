using UnityEngine;
using System.Collections;

public abstract class Item : MonoBehaviour {

    protected int itemOfferScore;

    public int ItemOfferScore { get { return this.itemOfferScore; } }
    
}
