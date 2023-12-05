using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zFrontBack : MonoBehaviour
{
    private float startPos;
    private bool extremeFront = false;
    private bool extremeBack = true;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (!extremeFront && extremeBack)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 15.0F);
            if (transform.position.z >= startPos + 25)
            {
                extremeFront = true;
                extremeBack = false;

            }



        }
        if (extremeFront && !extremeBack)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -15.0F);
            if (transform.position.z <= startPos - 25)
            {
                extremeFront = false;
                extremeBack = true;

            }



        }

       
    }
}