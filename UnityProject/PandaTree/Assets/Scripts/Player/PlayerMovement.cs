using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5.0f;
	public float acceleration = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MovePlayer(float radians, float speedModifier){
		Vector3 curPos = this.transform.position;
		Vector3 newPos = newPosition (curPos, radians, speedModifier);

		this.transform.Translate (newPos);
	}

	Vector3 newPosition(Vector3 curPos, float radians, float speedmodifier){
		Vector3 newPosition = new Vector3 ();

		newPosition = curPos;



		return newPosition;
	}
}
