using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject plat1;
    // Start is called before the first frame update
    void Start()
    {
        plat1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -25)
        {
            plat1.SetActive(true);
        
        }
    }
}
