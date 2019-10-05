using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Interactable : MonoBehaviour
{
    [SerializeField]
    protected Text message;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        message = GameObject.Find("Message").GetComponent < Text>() ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Interact()
    {

    }
    void OnMouseDown()
    {
        Interact();
    }
}
