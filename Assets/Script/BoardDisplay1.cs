using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BoardDisplay1 : MonoBehaviour
{
    public TMP_Text playerHP;
    public TMP_Text bossHP;

    // Update is called once per frame
    void Update()
    {
        playerHP.text = "Player Health: " + GameData.playerHealth.ToString();
        bossHP.text = "Enemy Health: " + GameData.bossHealth.ToString();

    }
}
