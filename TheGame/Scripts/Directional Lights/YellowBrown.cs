using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBrown : MonoBehaviour
{
    private Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        light.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            light.enabled = true;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            light.enabled = false;

        }
    }
}
