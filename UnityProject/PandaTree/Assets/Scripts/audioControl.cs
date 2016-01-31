using UnityEngine;
using System.Collections;

public class audioControl : MonoBehaviour {
	
	AudioSource fxSound; 
	public AudioClip backMusic; 
	void Start ()
	{
		fxSound = GetComponent<AudioSource> ();
		fxSound.Play ();
	}
}
