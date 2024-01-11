using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level : MonoBehaviour
{
    [SerializeField] private int idLV;
    [SerializeField] private TMP_Text text;
    [SerializeField] private GameObject panel;
    [SerializeField] private ObjectManager objectManager;
    [SerializeField] private LoadingData loadingData;
    // Start is called before the first frame update
    void Start()
    {
        objectManager = FindObjectOfType<ObjectManager>();
        loadingData = FindObjectOfType<LoadingData>();
        text.text = "LV "+ (idLV + 1).ToString();
        if (idLV < 5)
        {
            if (loadingData.players[objectManager.idPlayer].Levels[idLV] == 1)
                panel.SetActive(false);
        }    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getLevel()
    {
        if (idLV < 5 && objectManager.levels[idLV])
        {
            objectManager.level.SetActive(false);
            objectManager._level = Instantiate(objectManager.levels[idLV], objectManager.levels[idLV].transform.position, objectManager.levels[idLV].transform.rotation);
            objectManager._player = Instantiate(objectManager.tank[objectManager.idTank], objectManager.tank[objectManager.idTank].transform.position, objectManager.tank[objectManager.idTank].transform.rotation);
            objectManager.player = objectManager._player.GetComponent<Player>();
        }    
    }    
}
