using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private GameObject player;
    private GameObject child;
    private Transform target;

    void Start()
    {
        player = GameObject.Find("Player");
        child = player.transform.GetChild(0).gameObject;
        target = child.GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        var lookPos = target.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
    }
}
