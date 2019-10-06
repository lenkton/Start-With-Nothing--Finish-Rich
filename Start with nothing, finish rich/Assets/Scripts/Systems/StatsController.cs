using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour
{
    Text MoneyInfo;

    private int money;
    public int appearance;
    public int starvation;

    private void Start()
    {
        MoneyInfo = GameObject.Find("MoneyCount").GetComponent<Text>();
    }

    public int Money
    {
        get
        {
            return money;
        }
        set
        {
            money = value;
            MoneyInfo.text = value.ToString();
        }
    }
}
