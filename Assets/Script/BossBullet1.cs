using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet1 : MonoBehaviour
{
    private float speed = 5.0f;
    private float timer;
    private float time = 3.0f;

    private GameObject player;
    private GameObject playerChild1;
    private GameObject cam;
    private Transform target;
    private PlayerStats cr;

    //private GameObject enemy;
    private Boss1Stats bs;
    private Boss1 bo;

    public bool isDestroyed;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.Find("Player");
        playerChild1 = player.transform.GetChild(0).gameObject;
        cam = playerChild1.transform.GetChild(0).gameObject;

        target = cam.GetComponent<Transform>();
        cr = player.GetComponent<PlayerStats>();

        //enemy = GameObject.Find("Enemy1");

        bs = this.transform.GetComponentInParent<Boss1Stats>();
        //es = enemy.GetComponent<Enemy1Stats>();

        bo = this.transform.GetComponentInParent<Boss1>();
        //en = enemy.GetComponent<Enemy>();
        this.gameObject.transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        isDestroyed = false;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //this.gameObject.transform.LookAt(target);
        timer += Time.deltaTime;

        if (bs.isDied == true)
        {
            Destroy(this.gameObject);
            isDestroyed = true;
        }


        if (timer >= time)
        {
            Debug.Log("time done");
            bs.TakeDamage(50);
            Destroy(this.gameObject);
            bo.BulletSpawn();

        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("TakeDamage");
            cr.TakeDamage(10);
            Destroy(this.gameObject);
            bo.BulletSpawn();

        }
    }
}
