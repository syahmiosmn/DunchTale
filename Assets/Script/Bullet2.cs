using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    private float speed = 5.0f;
    private float timer;
    private float time = 3.0f;

    private GameObject player;
    private GameObject playerChild1;
    private GameObject cam;
    private GameObject LeftHand;
    private GameObject RightHand;
    private PlayerStats cr;

    private Enemy1Stats es;
    private Enemy2 en;

    void Start()
    {
        player = GameObject.Find("Player");
        playerChild1 = player.transform.GetChild(0).gameObject;        
        cam = playerChild1.transform.GetChild(0).gameObject;
        LeftHand = playerChild1.transform.GetChild(1).gameObject;
        RightHand = playerChild1.transform.GetChild(2).gameObject;        
        cr = player.GetComponent<PlayerStats>();
        es = this.transform.GetComponentInParent<Enemy1Stats>();
        en = this.transform.GetComponentInParent<Enemy2>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        timer += Time.deltaTime;

        if (es.isDied == true)
        {
            Destroy(this.gameObject);
        }


        if (timer >= time)
        {
            Debug.Log("time done");
            cr.TakeDamage(10);
            Destroy(this.gameObject);
            en.BulletSpawn();

        }

    }

    private void OnTriggerEnter(Collider collision)
    {

        if(collision.gameObject.tag == "LeftHand" || collision.gameObject.tag == "RightHand")
        {
            Debug.Log("HIT");
            es.TakeDamage(10);
            Destroy(this.gameObject);
            en.BulletSpawn();
        }


    }
}
