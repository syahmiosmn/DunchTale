using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class OpenChest : MonoBehaviour
{
    private CharacterController controller;
    private XRRig rig;
    private GameObject player;
    private PlayerStats ps;
    private float squatHeight;

    private bool startHeight;

    void Start()
    {
        player = GameObject.Find("Player");
        ps = player.transform.GetComponent<PlayerStats>();
        rig = player.GetComponent<XRRig>();
        controller = player.GetComponent<CharacterController>();
        startHeight = false;

    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            if (controller.height <= 1.5f)
            {
                ps.currentHealth = ps.currentHealth + 50;
                Destroy(this.gameObject);
                Debug.Log("Player squatted");
            }
            Debug.Log("Player has enter the chest zone");
        }
    }
}
