using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BoardDisplay : MonoBehaviour
{
    public TMP_Text playerHP;
    public TMP_Text enemyHP;

    // Update is called once per frame
    void Update()
    {
        playerHP.text = "Player Health: " + GameData.playerHealth.ToString();
        enemyHP.text = "Enemy Health: " + GameData.enemyHealth.ToString();

    }
}
