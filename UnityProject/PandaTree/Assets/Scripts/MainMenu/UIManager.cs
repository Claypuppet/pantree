using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class UIManager : MonoBehaviour {

    Canvas mCanvas;
    GameObject mMenuBackground;

	// Use this for initialization
	void Start () {
        mCanvas = GameObject.Find("MainMenuCanvas").GetComponent<Canvas>();
        mMenuBackground = GameObject.Find("menu_background");
    }
	
	// Update is called once per frame
	void Update () {

        GraphicRaycaster rayCaster = mCanvas.GetComponent<GraphicRaycaster>();
        PointerEventData pointerEventData = new PointerEventData(null);

        if(Application.isMobilePlatform) {
            // Handle touch input.
            foreach (Touch touch in Input.touches) {
                if (touch.phase != TouchPhase.Began)
                    continue;

                pointerEventData.position = touch.position;

                List<RaycastResult> results = new List<RaycastResult>();
                rayCaster.Raycast(pointerEventData, results);

                foreach(RaycastResult result in results)
                    ProcessRayCastResult(result);
            }
        }
        else if(Input.GetMouseButtonDown(0))
        {
            pointerEventData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();
            rayCaster.Raycast(pointerEventData, results);

            foreach(RaycastResult result in results)
                ProcessRayCastResult(result);
        }
	}

    void ProcessRayCastResult(RaycastResult rayCastResult) {
        Debug.Log(string.Format("rayCast hit: {0}", rayCastResult));
        if(rayCastResult.gameObject != null && rayCastResult.gameObject.Equals(mMenuBackground)) {
            StartGame();
        }
    }

    void StartGame() {
        Debug.Log("Starting game....!");
        SceneManager.LoadScene("Scenes/GameLevel");
    }
}
