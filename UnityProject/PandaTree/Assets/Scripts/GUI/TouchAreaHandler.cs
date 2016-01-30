using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TouchAreaHandler : MonoBehaviour {

    public GameObject thumbStickOuter;
    public GameObject thumbStickInner;
    private bool touchDown = false;
    private Vector2 basePoint;

    private ThumbStickHandler ThumbStickOuterHandler { get { return this.thumbStickOuter.GetComponent<ThumbStickHandler>(); } }
    private ThumbStickHandler ThumbStickInnerHandler { get { return this.thumbStickInner.GetComponent<ThumbStickHandler>(); } }

	// Use this for initialization
	void Start () {
        basePoint = new Vector2();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 touchInput;

        if (Input.touchCount > 0) {
            // Get touch position and convert to world position
            touchInput = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
            if (!this.touchDown) {
                // Record first touch down
                this.touchDown = true;
                this.SetOuterThumbStick(touchInput);
            }
            else {
                // Thumb moving
                Debug.Log(touchInput.ToString());
            }
        }
        else if (touchDown) {
            //touchDown = false;
        }

        // mouse debuggin
        if (Input.GetMouseButton(0)) {
            touchInput = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            if (!this.touchDown) {
                // Record first touch down
                //Debug.Log("NEW START" + touchInput.ToString());
                this.touchDown = true;
                this.basePoint = touchInput;
                this.ShowThumbStick();
                this.SetOuterThumbStick(touchInput);
            }
            else {
                // Thumb moving
                float deltaY = touchInput.y - this.basePoint.y;
                float deltaX = touchInput.x - this.basePoint.x;

                float angleInDegrees = Mathf.Atan2(deltaY, deltaX) * 180 / Mathf.PI;
                Debug.Log(angleInDegrees);
            }
        }
        else if (touchDown) {
            this.HideThumbStick();
            touchDown = false;
        }
	}

    private void SetOuterThumbStick(Vector2 pos) {
        this.ThumbStickOuterHandler.SetPosition(pos);
    }

    private void ShowThumbStick() {
        this.ThumbStickOuterHandler.gameObject.SetActive(true);
        this.ThumbStickInnerHandler.gameObject.SetActive(true);
    }

    private void HideThumbStick() {
        this.ThumbStickOuterHandler.gameObject.SetActive(false);
        this.ThumbStickInnerHandler.gameObject.SetActive(false);
    }
}
