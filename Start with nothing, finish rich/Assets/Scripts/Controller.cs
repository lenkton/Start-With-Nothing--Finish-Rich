using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private SpriteRenderer sprite;

    public float speed = .01f;
    private bool isLookingLeft = false;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
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
        float d = Input.GetAxis("Horizontal");
        pos.x += d*speed;
        transform.position = pos;
        if (isLookingLeft && (d > 0))
        {
            isLookingLeft = false;
            sprite.flipX = false;
        }
        else if (d<0)
        {
            isLookingLeft = !isLookingLeft;
            isLookingLeft = true;
            sprite.flipX = true;
        }
    }
}
