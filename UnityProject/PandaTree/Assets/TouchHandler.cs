using UnityEngine;
using System.Collections;

public class TouchHandler : MonoBehaviour {

	private Vector2 touchPos;
	public GameObject thumbStick;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount < 0)
			return;
		touchPos = Input.GetTouch (0).position;


	}

	void SummonThumbstick(Vector2 pos){
		
	}
}
