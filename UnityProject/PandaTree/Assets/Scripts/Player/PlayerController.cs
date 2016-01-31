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
		//setAnimationIdle ();
    }
    public void AnimatePlayer() {
		setAnimationRunning ();
    }

	public void setPlayerDirection(bool right){
		Debug.Log ("MOIMOI" + right);
		float dir = 0.0f;
		if (right) {
			dir = 0.0f;
		} else {
			dir = 180.0f;
		}
		Vector3 nullVect = new Vector3 (0, 0, 0);
		GameObject.Find ("prefab_MainCharacter").transform.rotation.SetFromToRotation(nullVect,new Vector3(0,dir,0));
	}

}
