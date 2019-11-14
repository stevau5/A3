using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
     public Material waterMat;
     float freq;
     private bool isPositive; 

    // Start is called before the first frame update
    void Start()
    {
        isPositive = true; 
    }

    // Update is called once per frame
    void Update()
    {
        freq = (waterMat.GetFloat("_NoiseFrequency"));

        if(isPositive){
            waterMat.SetFloat("_NoiseFrequency", freq+=0.01f);
        } 
        else 
        {
            waterMat.SetFloat("_NoiseFrequency", freq-=0.01f);
        }

        if(freq >= 1.6)
        {
            isPositive = false; 
        }

        if(freq <= -1.6)
        {
            isPositive = true; 
        }




    }



}
