using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : ThingManager<Item>
{

    protected override void Fill(GameObject gameObject, Item scriptableObject)
    {
        Text text = gameObject.GetComponentInChildren<Text>();
        text.text = scriptableObject.name;
    }
}
