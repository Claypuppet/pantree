using UnityEngine;
using System.Collections;

public class PlayerColliderHandler : MonoBehaviour {

    private GameObject collidingObject = null;
    private bool isColliding;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider col) {
        if (this.collidingObject != null)
            return;
        try {
            InteractableCollisionHandler handler = col.gameObject.GetComponent<InteractableCollisionHandler>();
            handler.Collide();
            this.collidingObject = col.gameObject;
            this.isColliding = true;
        }
        catch {
            // no collision handler
        }
    }

    void OnTriggerExit(Collider col) {
        if (this.isColliding && this.collidingObject != null) {
            Debug.Log("no more collision!");
            this.collidingObject = null;
            this.isColliding = false;
        }
    }

    public void Action() {
        if (this.isColliding && this.collidingObject != null) {
            try {
                this.collidingObject.GetComponent<InteractableCollisionHandler>().Action();
            }
            catch {

            }
        }
    }
}
