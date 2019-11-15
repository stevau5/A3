using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public GameObject player;
    public Text score_text; 

    // Update is called once per frame
    void Update()
    {
        score_text.text = "Score: " + player.GetComponent<PlayerMovement>().currentScore;
    }
}
