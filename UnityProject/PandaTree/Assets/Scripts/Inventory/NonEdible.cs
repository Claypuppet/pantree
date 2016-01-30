using UnityEngine;
using System.Collections;

public abstract class NonEdible : Item {
    protected bool isEdible = false;

    public bool IsEdible { get { return this.isEdible; } }
}
