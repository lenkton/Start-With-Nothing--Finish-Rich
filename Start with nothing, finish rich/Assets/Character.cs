using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = FindObjectOfType<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        text.text = "Hey, you! Get out of here!";
    }
}
