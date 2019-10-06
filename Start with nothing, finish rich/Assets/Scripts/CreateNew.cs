using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNew : MonoBehaviour
{

    public GameObject prefub;
    public Transform parent;


    public void Dothat()
    {
        Instantiate(prefub, parent);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
