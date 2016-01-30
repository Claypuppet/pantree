using UnityEngine;
using System.Collections;

public class GameHandler : MonoBehaviour {

	public GameObject EnvironmentPrefab;

	// Use this for initialization
	void Start () {
		EnvironmentPrefab = GameObject.FindGameObjectWithTag ("Environment");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
