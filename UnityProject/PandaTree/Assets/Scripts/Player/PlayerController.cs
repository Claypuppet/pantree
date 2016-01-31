using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerController : MonoBehaviour {
 
	Animator anim;

    // Use this for initialization
    void Start ()
    {
		//GameObject childFBX = GameObject.Find ("prefab_MainCharacter");
		anim = GetComponentInChildren<Animator> ();
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
		setAnimationIdle ();
    }
    public void AnimatePlayer() {
		
		setAnimationRunning ();
    }

}
