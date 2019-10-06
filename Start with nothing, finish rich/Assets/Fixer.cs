using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixer : MonoBehaviour
{
    Vector3 stat;

    private void Start()
    {
        stat = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = stat.x;
        pos.y = stat.y;
        transform.position = pos;

    }
}
