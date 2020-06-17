using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    private string nameBuilding;
    private bool earnReward;
    private bool coinEarned;
    private GameObject coins;


    private void Start()
    {
        nameBuilding = gameObject.name;
        earnReward = false;
        coinEarned = true;
        coins = transform.GetChild(0).gameObject;
        coins.SetActive(false);
    }
    private void Update()
    {
        if(earnReward == false)
        {
            if (nameBuilding == "HousePrototype(Clone)")
            {
                StartCoroutine(House());
            }
            if (nameBuilding == "LaboPrototype(Clone)")
            {
                StartCoroutine(Labo());
            }
            if (nameBuilding == "DockPrototype(Clone)")
            {
                StartCoroutine(Dock());
            }
        }
        

    }
    IEnumerator House()
    {
        earnReward = true;
        yield return new WaitForSeconds(5f);
        coins.SetActive(true);
        coinEarned = false;

    }
    IEnumerator Labo()
    {
        earnReward = true;
        yield return new WaitForSeconds(5f);
        coins.SetActive(true);
        coinEarned = false;
    }
    IEnumerator Dock()
    {
        earnReward = true;
        yield return new WaitForSeconds(5f);
        coins.SetActive(true);
        coinEarned = false;
    }
    private void OnMouseDown()
    {
        if(coinEarned == false)
        {
            if (nameBuilding == "HousePrototype(Clone)")
            {
                SystemManager.cash = SystemManager.cash + 15;
            }
            if (nameBuilding == "LaboPrototype(Clone)")
            {
                SystemManager.researchPoint = SystemManager.researchPoint + 15;     
            }
            if (nameBuilding == "DockPrototype(Clone)")
            {
                SystemManager.materials = SystemManager.materials + 15;  
            }
            coins.SetActive(false);
            earnReward = false;
            coinEarned = true;
        }
        

    }
}
