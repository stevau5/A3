using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;


    private void Start()
    {
        speed = 2f;
        width = 40;
        height = 40;
    }

    // Update is called once per frame
    void Update()
    {


        timeCounter += Time.deltaTime * speed;
        float x = Mathf.Cos(timeCounter) * width;
        float y = Mathf.Sin(timeCounter) * height;
        float z = 40f; 

        transform.position = new Vector3(x, y, z);
    }
}
//Mathf.Sin(timeCounter) * height;
//Mathf.Cos(timeCounter) * width;