﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerController : MonoBehaviour {

    public float moveForce = 5f;

    Vector3 position;
    Transform myTrans;

    // Use this for initialization
    void Start ()
    {
        myTrans = this.transform;
        position = myTrans.transform.position;
        Debug.Log(position);
	}

    // Update is called once per frame
    void FixedUpdate()
    {

        float moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float moveVertical = CrossPlatformInputManager.GetAxis("Vertical");

        if (moveHorizontal > 0 && moveHorizontal <= 1)
        {

        }
        if (moveHorizontal >= -1 && moveHorizontal < 0)
        {
            
        }

    }
}