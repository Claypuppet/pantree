using UnityEngine;
using System.Collections;

public abstract class InteractablePlace : MonoBehaviour {

    public GameObject gameHandler;

    protected GameHandler _GameHandler { get { return this.gameHandler.GetComponent<GameHandler>(); } }

    // can be interacted with
    public virtual void Interact() {
        
    }
}
