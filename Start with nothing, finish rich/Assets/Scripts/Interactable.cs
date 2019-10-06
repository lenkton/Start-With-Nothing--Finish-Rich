using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Interactable : MonoBehaviour
{

    ItemManager im;

    public Item requiredItem;

    [SerializeField]
    [MultilineAttribute(5)]
    private string defaultMessage = "";
    [SerializeField]
    [MultilineAttribute(5)]
    private string accessedMessage = "";

    [SerializeField]
    protected Text message;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        message = GameObject.Find("Message").GetComponent < Text>() ;
        im = FindObjectOfType<ItemManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Interact()
    {
        if (im.Things.Contains(requiredItem))
        {
            message.text = accessedMessage;
        }
        else
            message.text = defaultMessage;
    }
    void OnMouseDown()
    {
        Interact();
    }
}
