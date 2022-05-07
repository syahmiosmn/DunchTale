using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBattle1 : MonoBehaviour
{
    private GameObject player;
    private PlayerMovementContinuous playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerMovement = player.GetComponent<PlayerMovementContinuous>();
        playerMovement.enabled = false;
    }
}
