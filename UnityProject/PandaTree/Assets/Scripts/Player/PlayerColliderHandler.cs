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

    void OnCollisionEnter(Collision col) {
        Debug.Log("collision!");
        col.gameObject.GetComponent<InteractableCollisionHandler>();
        this.collidingObject = col.gameObject;
        this.isColliding = true;
        col.gameObject.SetActive(false);
    }

    void onCollisionExit(Collision col) {
        Debug.Log("no more collision!");
        this.collidingObject = null;
        this.isColliding = false;
    }

    public void Action() {
        if (this.isColliding && this.collidingObject != null) {
            this.collidingObject.GetComponent<InteractableCollisionHandler>().Action();
        }
    }
}
