using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentGoldText : MonoBehaviour
{
    public GameObject player;
    public Text currentGoldText;

    // Update is called once per frame
    void Update()
    {
        currentGoldText.text = "Current Gold: " + player.GetComponent<PlayerMovement>().currentGold;
    }
}
