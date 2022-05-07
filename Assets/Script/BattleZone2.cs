using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleZone2 : MonoBehaviour
{
    private GameObject player;
    private Transform playerPos;
    void Start()
    {
        player = GameObject.Find("Player");
        playerPos = player.GetComponent<Transform>();
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "Player")
        {
            GameData.playerLastPos = playerPos.position; // save last player position 
            SceneManager.LoadScene(4);
        }

    }

}
