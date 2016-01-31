using UnityEngine;
using System.Collections;

public class InteractableCollisionHandler : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void Collide() {

    }

    public void Action() {
        try {
            this.gameObject.GetComponentInParent<CollectableItem>().Interact();
        }
        catch {
            // OK no item!
        }
        try {
            this.gameObject.GetComponent<TreeRoot>().Interact();
        }
        catch {
            // OK no tree root either!
        }
    }
}
