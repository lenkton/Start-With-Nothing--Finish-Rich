using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : Interactable
{
    [SerializeField]
    private int money;
    [SerializeField]
    private bool isLooted = false;
    [SerializeField]
    private Item item;

    public void Loot()
    {
        if (isLooted)
        {
            message.text ="You have already looted the spot!";
        }
        else
        {
            message.text = "You collected $" + money+ (item==null?"":" and "+item.name);
            isLooted = true;
        }
    }
    public override void Interact()
    {
        base.Interact();
        Loot();

    }

}
