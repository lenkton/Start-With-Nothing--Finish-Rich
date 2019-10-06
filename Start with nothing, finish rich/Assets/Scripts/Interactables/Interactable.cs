using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public  class Interactable : MonoBehaviour
{
    //system links
    protected StatsController stats;
    protected QuestSystem qs;
    protected AccessSystem accessSystem;
    protected ItemManager itemManager;

    [SerializeField]
    protected Text message;


    //rewards
    [SerializeField]
    private int MoneyReward =0;

    [SerializeField]
    private Access accessReward=null;

    [SerializeField]
    private Item itemReward=null;


    
    //requirements
    [SerializeField]
    private Item requiredItem=null;
    [SerializeField]
    private Access requredAccess = null;

    //messages
    [SerializeField]
    [MultilineAttribute(5)]
    private string defaultMessage = "";
    [SerializeField]
    [MultilineAttribute(5)]
    private string accessedMessage = "";

    //todo??
    [SerializeField]
    private UnityEvent Success;

    
    // Start is called before the first frame update
    protected virtual void Start()
    {
        message = GameObject.Find("Message").GetComponent < Text>() ;
        itemManager = FindObjectOfType<ItemManager>();
        stats = FindObjectOfType<StatsController>();
        qs = FindObjectOfType<QuestSystem>();
        accessSystem = FindObjectOfType<AccessSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Interact()
    {
        if ((  requiredItem  == null|| itemManager.Things.Contains(requiredItem))
            &&(requredAccess == null|| accessSystem.Things.Contains(requredAccess)))
        {
            message.text = accessedMessage;

            Success?.Invoke();

            if (itemReward) itemManager.Add(itemReward);
            stats.Money += MoneyReward;
            if (accessReward) accessSystem.Add(accessReward);
        }
        else
        {
            message.text = defaultMessage;
        }
    }
    void OnMouseDown()
    {
        Interact();
    }
}