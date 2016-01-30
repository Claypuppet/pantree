using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameHandler : MonoBehaviour {

    private int playerScore;

    public int PlayerScore { get { return this.playerScore; } }

	// Use this for initialization
	void Start () {
        this.playerScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
