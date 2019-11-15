using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusMove : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;
    public GameObject spikes;

    int counter;


    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        width = 15;
        height = 15;
        counter = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;
        float x = Mathf.Cos(timeCounter) * width;
        float y = 40.5f;
        float z = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x, y, z);

        if(counter == 0)
        {
            Instantiate(spikes, new Vector3(x, y, z), Quaternion.identity);
            counter++;
        }



    }
}
