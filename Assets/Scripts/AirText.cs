using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirText : MonoBehaviour
{
    public GameObject player;
    public Text airText;

    // Update is called once per frame
    void Update()
    {
        airText.text = "Air: " + player.GetComponent<PlayerMovement>().air;
        if(player.GetComponent<PlayerMovement>().air < 0.0f)
        {
            airText.text = "DEAD";

        }
    }
}
