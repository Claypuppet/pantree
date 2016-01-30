using UnityEngine;
using System.Collections;

public class TouchButtonLogic : MonoBehaviour {
	
	void Update ()
    {
	    if (Input.touches.Length <= 0)
        {
            // if no touches then execute this code.
        }
        else
        {
            // loop through all the touches on screen
            for (int i = 0; i < Input.touchCount; i++)
            {
                //execute this code for current touch on screen.

            }
        }
	}
}
