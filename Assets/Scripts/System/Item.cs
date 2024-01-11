using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private int cost;
    [SerializeField] private Image img;
    [SerializeField] private TMP_Text text;
    [SerializeField] private ObjectManager objectManager;

    // Start is called before the first frame update
    void Start()
    {
        text.text = cost.ToString();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getBuyItem()
    {
        if (cost > objectManager.loadingData.players[objectManager.idPlayer].Gold)
        {
            objectManager.uiNotBuy.SetActive(true);
        }
        else
        {
            objectManager.uiBuy.SetActive(true);
            objectManager.textBuy.text = $"Are you sure you want to buy this item for {cost} gold?";
            objectManager.idItem = id;
            objectManager.tankOrItem = 1;
            objectManager.cost = cost;
        }

    }
}
