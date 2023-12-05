using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleChange : MonoBehaviour
{
    private bool large = false;
    private bool small = true;
    public float scaleChanger = 0.09F;
    public float maxScale=400;
    public float minScale=100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (small)
        {
            transform.localScale += new Vector3(scaleChanger, 0, 0);
            if (transform.localScale.x >= maxScale)
            {
                large = true;
                small = false;
            
            }
        }
        if (large)
        {
            transform.localScale -= new Vector3(scaleChanger, 0, 0);
            if (transform.localScale.x <= minScale)
            {
                large = false;
                small = true;

            }


        }




        
    }

    

}
