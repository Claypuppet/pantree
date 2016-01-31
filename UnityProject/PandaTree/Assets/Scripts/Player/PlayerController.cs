using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerController : MonoBehaviour {

    public float MoveSpeed = 5f;

    private GameObject collidingObject;
    private bool isColliding;

    Vector3 position;
    Transform myTrans;

	Animator anim;

    // Use this for initialization
    void Start ()
    {
        myTrans = this.transform;
        position = myTrans.transform.position;
		//GameObject childFBX = GameObject.Find ("prefab_MainCharacter");
		anim = GetComponentInChildren<Animator> ();
        Debug.Log(position);
	}

	public void setAnimationRunning(){
		anim.SetBool ("playerMoving", true);
	}

	public void setAnimationIdle(){
		anim.SetBool ("playerMoving", false);
	}

	public void doPickUpAnimation(){
		anim.SetTrigger ("pickUp");
	}

    // Update is called once per frame
    void Update()
    {
        /*
        float DeltaTime = Time.deltaTime;
        float moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float moveVertical = CrossPlatformInputManager.GetAxis("Vertical");

        if (moveHorizontal > 0 && moveHorizontal <= 1)
        {
            myTrans.Translate(moveHorizontal * MoveSpeed * DeltaTime, 0, 0, 0);
        }
        if (moveHorizontal >= -1 && moveHorizontal < 0)
        {
            myTrans.Translate(moveHorizontal * MoveSpeed * DeltaTime, 0, 0);
        }
        */
    }

    void OnCollisionEnter(Collision col) {
        Debug.Log("collision!");
        this.collidingObject = col.gameObject;
        this.collidingObject.GetComponent<InteractableCollisionHandler>().Collide();
        this.isColliding = true;
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
