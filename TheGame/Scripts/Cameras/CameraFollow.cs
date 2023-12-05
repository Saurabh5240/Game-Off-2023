using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float cameraDistance = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float xPos = player.transform.position.x;
        float yPos = player.transform.position.y + 10.0F;
        float zPos = player.transform.position.z + 25.0F;

        transform.position = new Vector3(xPos, yPos, zPos);

    }
}
