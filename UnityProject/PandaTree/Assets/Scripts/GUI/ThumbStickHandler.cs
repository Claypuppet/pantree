using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ThumbStickHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetPosition(Vector2 pos) {

        this.gameObject.SetActive(true);

        this.gameObject.GetComponent<RectTransform>().anchorMin = pos;
        this.gameObject.GetComponent<RectTransform>().anchorMax = pos;
        
    }
}
