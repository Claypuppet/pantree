using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerController : MonoBehaviour {
 
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
    public void AnimatePlayer() {

    }

}
