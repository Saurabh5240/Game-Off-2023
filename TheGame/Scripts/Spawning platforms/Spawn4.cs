using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn4 : MonoBehaviour
{
    public GameObject enemy;   // Start is called before the first frame update

    private float offsetx;
    private float offsetz;
    public int rangeX = 20;

    public int enemiesOnPlat;
    private int totalEnemy = 0;

    private PlayerController player;
    public GameObject plat5;
    private int enemy1;
    private bool level5 = false;

    void Start()
    {

        player = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (player.onLevel4 && totalEnemy < 1)
        {
            SpawnEnemies();
            totalEnemy += 1;


        }

        enemy1 = FindObjectsOfType<Enemy3>().Length;

        if (enemy1 > 1)
        {
            level5 = false;

        }
        else if (enemy1 == 0)
        {
            level5 = true;

        }

        if (!level5)
        {


            plat5.SetActive(false);


        }

        else if (level5)
        {
            plat5.SetActive(true);

        }



    }


    private void SpawnEnemies()
    {
        for (int i = 0; i <= enemiesOnPlat; i++)
        {
            Instantiate(enemy, RandomSpawnPos(), enemy.transform.rotation);

        }


    }

    private Vector3 RandomSpawnPos()
    {
        offsetx = Random.Range(-rangeX, rangeX);
        offsetz = Random.Range(-20, 20);
        float xPos = transform.position.x + offsetx;
        float yPos = transform.position.y + 3.0F;
        float zPos = transform.position.z + offsetz;
        Vector3 randPos = new Vector3(xPos, yPos, zPos);
        return randPos;

    }
}
