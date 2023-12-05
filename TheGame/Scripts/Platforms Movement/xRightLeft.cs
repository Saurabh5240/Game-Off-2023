using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xRightLeft : MonoBehaviour
{
    private float startPos;
    private bool extremeLeft=false;
    private bool extremeRight= true;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!extremeLeft && extremeRight)
        {
            transform.Translate(Vector3.left * Time.deltaTime * -15.0F);
            if (transform.position.x >= startPos + 25)
            {
                extremeLeft = true;
                extremeRight = false;

            }



        }
        if (extremeLeft && !extremeRight)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 15.0F);
            if (transform.position.x <= startPos - 25)
            {
                extremeLeft = false;
                extremeRight = true;

            }



        }

        
    }
}
