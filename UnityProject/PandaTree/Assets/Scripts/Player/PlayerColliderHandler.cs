using UnityEngine;
using System.Collections;

public class PlayerColliderHandler : MonoBehaviour {

    private GameObject collidingObject;
    private bool isColliding;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider col) {
        try {
            InteractableCollisionHandler handler = col.gameObject.GetComponent<InteractableCollisionHandler>();
            Debug.Log("collision!");
            this.collidingObject = col.gameObject;
            this.isColliding = true;
            handler.Collide();
            this.Action();
        }
        catch {
            // no collision handler
        }
    }

    void OnTriggerExit(Collider col) {
        if (isColliding) {
            Debug.Log("no more collision!");
            this.collidingObject = null;
            this.isColliding = false;
        }
    }

    public void Action() {
        if (this.isColliding && this.collidingObject != null) {
            Debug.Log("pickup");
            this.collidingObject.GetComponent<InteractableCollisionHandler>().Action();
        }
    }
}
