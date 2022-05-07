using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private XRRig rig;

    //public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        Debug.Log(currentHealth);
        rig = GetComponent<XRRig>();
        currentHealth = GameData.playerHealth;

        Scene scene = SceneManager.GetActiveScene();
        int currentScene = scene.buildIndex;
        if (currentScene == 0)
        {
            GameData.playerHealth = 100;
        }
    }

    public void TakeDamage (int damage)
    {
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        currentHealth -= damage;
        GameData.playerHealth = currentHealth;
        Debug.Log(transform.name + "takes" + damage + " damage");
        
        if(currentHealth <= 0)
        {
            Die();
        }
    }
    
    public virtual void Die()
    {
        Debug.Log(transform.name + "Died");
        GameData.encounters = 0; 
        SceneManager.LoadScene(0);
    }

}
