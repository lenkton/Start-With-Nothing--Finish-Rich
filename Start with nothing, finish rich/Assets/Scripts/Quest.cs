using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Quest", menuName = "Quest", order = 51)]
public class Quest : ScriptableObject
{
    [SerializeField]
    private string  questName;
    [SerializeField][MultilineAttribute(5)]
    private string  description;
    [SerializeField]
    private int     reward;

    public string QuestName
    {
        get
        {
            return questName;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }
    public int Reward
    {
        get
        {
            return reward;
        }
    }

}
