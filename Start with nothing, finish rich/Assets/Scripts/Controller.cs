using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = .01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit;
            if (hit = Physics2D.Raycast(ray.origin, ray.direction * 100f)){
                if (hit.transform.tag == "Character")
                {
                    hit.transform.GetComponent<Character>().Interact();
                }
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.x += Input.GetAxis("Horizontal")*speed;
        transform.position = pos;
    }
}
