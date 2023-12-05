using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn5 : MonoBehaviour
{
    public GameObject enemy;   // Start is called before the first frame update

    private float offsetx ;
    private float offsetz;
    public int rangeX = 20;

    public int enemiesOnPlat;
    private int totalEnemy = 0;

    private PlayerController player;
    

    void Start()
    {

        player = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if(player.onLevel5&& totalEnemy<1)
        {
            SpawnEnemies();
            totalEnemy += 1;


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
