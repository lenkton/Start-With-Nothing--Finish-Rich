using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger:MonoBehaviour
{
    [SerializeField]
    private Transform player;
    
    [SerializeField]
    private Transform CharacterLayer;
    public void GoTo(Transform scene)
    {
        Vector3 pos = player.position;
        pos.z = scene.position.z + CharacterLayer.position.z;
        player.position = pos;
    }
}
