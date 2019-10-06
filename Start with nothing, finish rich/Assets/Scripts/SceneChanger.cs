using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger:MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform shop;
    [SerializeField]
    private Transform CharacterLayer;
    public void GoToShop()
    {
        Vector3 pos = player.position;
        pos.z = shop.position.z + CharacterLayer.position.z;
        player.position = pos;
    }
}
