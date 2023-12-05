using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    private GameObject player;
    private Vector3 moveDir;

    private Rigidbody enemyRb;

    public float force = 6.0F;


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(moveDir * force);


        if (transform.position.y < -35)
        {
            Destroy(gameObject);

        }
    }
}