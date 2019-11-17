using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthMonitor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Image img;
    public Text deathText;
     

    // Update is called once per frame
    void Update()
    {
        float currentAir = player.GetComponent<PlayerMovement>().air;
        ColorBlock colorBlock = new ColorBlock();

        if (currentAir <= 0)
        {
            colorBlock.normalColor = new Color(255.0f, 0.0f, 0.0f, .5f);
            deathText.text = "Oh Dear You're Dead! Click ESC to restart";

        // :Load new game! 




        }
        else
        {
            colorBlock.normalColor = new Color(255.0f, 0.0f, 0.0f, -.5f + 1.0f - currentAir/100f);
        }

        


        img.color = colorBlock.normalColor;
    }
}
