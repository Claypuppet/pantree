using UnityEngine;
using System.Collections;


public class JoyStick : MonoBehaviour
{

    

    void Update()
    {
        if (Input.touchCount < 0)
            return;

        Touch touch = Input.GetTouch(0);


    }
       
}
