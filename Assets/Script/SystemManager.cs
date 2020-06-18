using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemManager : MonoBehaviour
{
    public static int selection;
    public static int researchPoint, cash, materials, food, staff, maxStaff;

    private void Start()
    {
        selection = 0;
        researchPoint = 100;
        cash = 100;
        materials = 100;
        food = 100;
        staff = 5;
        maxStaff = 5;
    }
    private void Update()
    {
        GameObject.Find("Cash").GetComponentInChildren<Text>().text = "" + cash;
        GameObject.Find("Food").GetComponentInChildren<Text>().text = "" + food;
        GameObject.Find("Materials").GetComponentInChildren<Text>().text = "" + materials;
        GameObject.Find("ResearchPoint").GetComponentInChildren<Text>().text = "" + researchPoint;
        GameObject.Find("Staff").GetComponentInChildren<Text>().text = staff + "/" + maxStaff;
        
    }
    public void ClickHouse()
    {
        selection = 0;
    }
    public void ClickLabo()
    {
        selection = 1;
    }
    public void ClickDock()
    {
        selection = 2;
    }
    public void ClickFarm()
    {
        selection = 3;
    }
    public void ClickMarket()
    {
        selection = 4;
    }
}
