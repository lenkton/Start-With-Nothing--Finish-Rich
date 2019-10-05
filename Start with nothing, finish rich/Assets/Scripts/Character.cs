using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Character : Interactable
{
    public CanvasGroup CanvasGroup;
    public Text text;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        text = FindObjectOfType<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void  Interact()
    {
        message.text = "Hey, you! Get out of here!";
    }

    
}
