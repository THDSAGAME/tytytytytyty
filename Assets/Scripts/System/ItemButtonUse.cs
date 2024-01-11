using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemButtonUse : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private TMP_Text text;
    [SerializeField] private int id;
    [SerializeField] private ObjectManager objectManager;
    // Start is called before the first frame update
    void Start()
    {
        updateCount();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player)
            player = FindObjectOfType<Player>();
    }
    public void updateCount()
    {
        text.text = objectManager.loadingData.players[objectManager.idPlayer].Items[id].ToString();
    }    
    public void getUseItem()
    {

    }
}
