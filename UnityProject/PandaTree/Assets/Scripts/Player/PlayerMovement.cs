﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float horizontalSpeed = 5.0f;
    public float verticalSpeed = 5.0f;
	public float acceleration = 1.0f;
	public bool directionRight = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MovePlayer(float radians, float speedModifier){
		Vector3 curPos = this.transform.position;
        Vector3 newPos = newPosition(curPos, radians, speedModifier);

		if (curPos.x < newPos.x) {
			directionRight = false;
		} else {
			directionRight = true;
		}

		this.transform.Translate(newPos);

        this.gameObject.GetComponent<PlayerController>().AnimatePlayer();
		//this.gameObject.GetComponent<PlayerController>().setPlayerDirection(directionRight);
	}

	private Vector3 newPosition(Vector3 curPos, float radians, float speedmodifier){
        Vector3 newPosition = new Vector3(Mathf.Cos(radians) / 100, Mathf.Sin(radians) / 100, 0);

        newPosition.x *= this.horizontalSpeed;
        newPosition.y *= this.verticalSpeed;

		return newPosition;
	}
}
