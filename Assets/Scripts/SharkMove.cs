using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkMove : MonoBehaviour
{
    public Transform sharkTransform; 
    float speed = 100f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos =  sharkTransform.localPosition;
        sharkTransform.localPosition = new Vector3(pos.x, pos.y, pos.z - speed*Time.deltaTime);

        if(pos.z < -130)
        {
            sharkTransform.localPosition = new Vector3(pos.x, pos.y, 143);
        }  

        
    }
}
