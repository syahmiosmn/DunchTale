using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player; 
    [SerializeField] GameObject[] battles; 

    void Start()
    {
        SceneLoadSetup(); 
    }

    void SceneLoadSetup()
    {
        if (GameData.encounters > 0) player.transform.position = GameData.playerLastPos;

        for (int i = 0; i < battles.Length; i++)
        {
            if (i < GameData.encounters) battles[i].SetActive(false); 
        }
    }

}

public static class GameData
{
    public static Vector3 playerLastPos = Vector3.zero; 
    public static int encounters = 0;

    public static int playerHealth = 100;
    public static int enemyHealth = 100;
    public static int bossHealth = 1000;
}