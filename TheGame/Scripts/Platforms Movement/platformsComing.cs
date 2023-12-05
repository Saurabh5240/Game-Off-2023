using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformsComing : MonoBehaviour
{
    public float forwardSpeed = 100.0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);

        if (transform.position.z > 350)
        {
            Destroy(gameObject);
        
        }
    }
}
