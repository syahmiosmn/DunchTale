using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Battle : MonoBehaviour
{
    private GameObject player;
    private PlayerMovementContinuous playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerMovement = player.GetComponent<PlayerMovementContinuous>();
        playerMovement.speed = 0f;
    }

}
