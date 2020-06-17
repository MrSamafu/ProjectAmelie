using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public static int selection;

    private void Start()
    {
        selection = 0;
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
