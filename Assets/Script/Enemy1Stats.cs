using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy1Stats : MonoBehaviour
{
    public int currentHealth { get; private set; }

    private GameObject player;
    private PlayerMovementContinuous playerMovement;

    public bool isDied = false;


    private void Awake()
    {
        player = GameObject.Find("Player");
        playerMovement = player.GetComponent<PlayerMovementContinuous>();
            currentHealth = 100;
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        GameData.enemyHealth = currentHealth;
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
        GameData.encounters++; // update encounter 
        SceneManager.LoadScene(1); 
    }
    
}
