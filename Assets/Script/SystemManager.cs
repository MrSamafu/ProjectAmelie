using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemManager : MonoBehaviour
{
    public static int selection;
    public static int researchPoint, cash, materials, food;

    private void Start()
    {
        selection = 0;
        researchPoint = 0;
        cash = 0;
        materials = 0;
        food = 0;
    }
    private void Update()
    {
        GameObject.Find("Cash").GetComponentInChildren<Text>().text = "" + cash;
        GameObject.Find("Food").GetComponentInChildren<Text>().text = "" + food;
        GameObject.Find("Materials").GetComponentInChildren<Text>().text = "" + materials;
        GameObject.Find("ResearchPoint").GetComponentInChildren<Text>().text = "" + researchPoint;
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
}
