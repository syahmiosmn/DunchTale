using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    //private GameObject bullet;
    private Transform boss1;
    public Animator ani;

    void Start()
    {
        BulletSpawn();
    }
    void Update()
    {
        boss1 = GetComponent<Transform>();
        //Debug.Log(enemy.transform.position.x);

        //BulletSpawn();
    }
    public void BulletSpawn()
    {
        int bul = Random.Range(0, 4);
        ani.Play("Fireball Shoot");
        if (bul >= 4)
        {
            var bulletOne = Instantiate(Resources.Load("BossBullet1") as GameObject, new Vector3(0.5f + this.transform.position.x, 5.0f  + this.transform.position.y, this.transform.position.z), this.transform.rotation);
            bulletOne.transform.SetParent(this.gameObject.transform);
        }
        else if (bul >= 2)
        {
            var bulletTwo = Instantiate(Resources.Load("BossBullet1") as GameObject, new Vector3(-0.5f + this.transform.position.x, 5.0f + this.transform.position.y, this.transform.position.z), this.transform.rotation);
            bulletTwo.transform.SetParent(this.gameObject.transform);

        }
        else
        {

            var bulletThree = Instantiate(Resources.Load("BossBullet1") as GameObject, new Vector3(this.transform.position.x, 5.0f + this.transform.position.y, this.transform.position.z), this.transform.rotation);
            bulletThree.transform.SetParent(this.gameObject.transform);
        }


        //var instant = Instantiate(Resources.Load("Cube") as GameObject, new Vector3(0.5f + enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z), enemy.transform.rotation);
        //instant.transform.SetParent(this.gameObject.transform);

    }
}