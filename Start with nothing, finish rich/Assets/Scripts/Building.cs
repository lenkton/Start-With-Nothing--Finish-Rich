using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : Interactable
{
    // Start is called before the first frame update
    public override void Interact()
    {
        base.Interact();
        message.text = "You cannot ented this building for now";
    }
}
