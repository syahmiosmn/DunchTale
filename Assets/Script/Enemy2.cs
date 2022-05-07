using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private Transform enemy;
    public Animator ani;

    void Start()
    {
        BulletSpawn();
    }

    void Update()
    {
        enemy = GetComponent<Transform>();
    }

    public void BulletSpawn()
    {
        int bul = Random.Range(0, 4);
        ani.Play("attack01");
        if (bul >= 4)
        {
            var bulletOne = Instantiate(Resources.Load("Bullet2") as GameObject, new Vector3(0.5f + this.transform.position.x, this.transform.position.y, this.transform.position.z), this.transform.rotation);
            bulletOne.transform.SetParent(this.gameObject.transform);
        }
        else if (bul >= 2)
        {
            var bulletTwo = Instantiate(Resources.Load("Bullet2") as GameObject, new Vector3(-0.5f + this.transform.position.x, this.transform.position.y, this.transform.position.z), this.transform.rotation);
            bulletTwo.transform.SetParent(this.gameObject.transform);

        }
        else
        {

            var bulletThree = Instantiate(Resources.Load("Bullet2") as GameObject, new Vector3(this.transform.position.x, 1.0f + this.transform.position.y, this.transform.position.z), this.transform.rotation);
            bulletThree.transform.SetParent(this.gameObject.transform);
        }
    }
}
