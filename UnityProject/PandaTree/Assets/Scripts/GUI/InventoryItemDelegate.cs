using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryItemDelegate : MonoBehaviour {

    public GameObject textField;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetText(string text) {
        this.textField.GetComponent<Text>().text = text;
    }
}
