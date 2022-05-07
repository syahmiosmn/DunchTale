using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Stats : MonoBehaviour
{
    //public int maxHealth = 1000;
    public int currentHealth { get; private set; }

    private GameObject player;
    private PlayerMovementContinuous playerMovement;

    public bool isDied = false;

    private void Start()
    {
        currentHealth = 1000;    
    }

    private void Awake()
    {
        player = GameObject.Find("Player");
        playerMovement = player.GetComponent<PlayerMovementContinuous>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        GameData.bossHealth = currentHealth;
        Debug.Log(transform.name + "takes" + damage + " damage");

        if (currentHealth <= 0)
        {
            isDied = true;
            Die();
        }
    }

    public void Die()
    {
        Debug.Log(transform.name + "Died");
        Destroy(this.gameObject);
        playerMovement.enabled = true;
        isDied = true;
    }

}
