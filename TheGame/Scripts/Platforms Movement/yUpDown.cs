using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yUpDown : MonoBehaviour
{
    private float startPos;
    private bool extremeUp = false;
    private bool extremeDown = true;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (!extremeUp && extremeDown)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 15.0F);
            if (transform.position.y >= startPos + 50)
            {
                extremeUp = true;
                extremeDown = false;

            }



        }
        if (extremeUp && !extremeDown)
        {
            transform.Translate(Vector3.up * Time.deltaTime * -15.0F);
            if (transform.position.y <= startPos - 25)
            {
                extremeUp = false;
                extremeDown = true;

            }



        }


    }
}
