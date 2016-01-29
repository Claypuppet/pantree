using UnityEngine;
using System.Collections;

public abstract class NonEatable : Item {
    protected bool isEatable = false;

    public bool IsEatable { get { return this.isEatable; } }
}
