using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : Interactable
{
    public override void Interact()
    {
        Debug.Log("Interacting with pickupable object");
    }
}
