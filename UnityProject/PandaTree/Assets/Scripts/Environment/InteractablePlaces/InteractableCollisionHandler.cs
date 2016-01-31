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
        this.gameObject.GetComponentInParent<CollectableItem>().Interact();
    }
}
