using UnityEngine;
using System.Collections;

public class Banana : Edible {

	public Banana() {
        // Yes, this is a public banana
        this.name = "Banana";
        this.itemOfferScore = 10;
        this.restoreAmount = 10;
	}
}
