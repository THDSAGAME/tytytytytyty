using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    [SerializeField] private Player player;
    // Update is called once per frame
    void Update()
    {
        if (player)
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        else
            player = FindObjectOfType<Player>();
    }
}
