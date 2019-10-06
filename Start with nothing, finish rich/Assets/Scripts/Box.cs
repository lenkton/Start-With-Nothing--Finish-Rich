using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Box : Interactable
{
    private StatsController stats;
    private ItemManager itemManager;
    [SerializeField]
    private int money=0;
    [SerializeField]
    private bool isLooted = false;
    [SerializeField]
    private Item item=null;

    protected override void Start()
    {
        base.Start();
        stats = FindObjectOfType<StatsController>();
        itemManager = FindObjectOfType<ItemManager>();
    }

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
            stats.Money += money;
            if(item!=null)
                itemManager.Add(item);

        }
    }
    public override void Interact()
    {
        base.Interact();
        Loot();

    }

}
