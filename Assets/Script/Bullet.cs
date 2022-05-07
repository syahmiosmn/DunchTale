using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 5.0f;
    private float timer;
    private float time = 3.5f;
    private GameObject player;
    private GameObject playerChild1;
    private GameObject cam;
    private Transform target;
    private PlayerStats cr;

    //private GameObject enemy;
    private Enemy1Stats es;
    private Enemy en;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerChild1 = player.transform.GetChild(0).gameObject;
        cam = playerChild1.transform.GetChild(0).gameObject;
        target = cam.GetComponent<Transform>();
        cr = player.GetComponent<PlayerStats>();
        es = this.transform.GetComponentInParent<Enemy1Stats>();
        en = this.transform.GetComponentInParent<Enemy>();

        this.gameObject.transform.LookAt(target);      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        timer += Time.deltaTime;

        if (es.isDied == true)
        {
            Destroy(this.gameObject);
        }
        

        if( timer >= time)
        {
            Debug.Log("time done");
            es.TakeDamage(30);
            Destroy(this.gameObject);
            en.BulletSpawn();
          
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("TakeDamage");
            cr.TakeDamage(10);
            Destroy(this.gameObject);
            en.BulletSpawn();
        }
    }
}
