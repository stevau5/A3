using UnityEngine;
using Unity.Collections;

public class CollisionDetection : MonoBehaviour
{

    public GameObject player;
    private void OnCollisionEnter(Collision collision)
    { 

        if(collision.collider.tag == "Shark")
        {
            Debug.Log("Shark hit me");
            player.GetComponent<PlayerMovement>().air -= 15;
        }

        if(collision.collider.tag == "Octopus")
        {
            Debug.Log("Octopus hit me");
            player.GetComponent<PlayerMovement>().air -= 40;

        }
        if(collision.collider.tag == "Particle")
        {
            player.GetComponent<PlayerMovement>().air -= 10;
        }

        if(collision.collider.name == "black_perl")
        {
            Debug.Log("Ship SHip!!!");
            player.GetComponent<PlayerMovement>().air = 100;
            player.GetComponent<PlayerMovement>().jumpVelocity = 20;
            player.GetComponent<PlayerMovement>().movementSpeed = 30f;

            if(player.GetComponent<PlayerMovement>().hasGold)
            {
                player.GetComponent<PlayerMovement>().currentScore += player.GetComponent<PlayerMovement>().currentGold;
                player.GetComponent<PlayerMovement>().currentGold = 0;
                player.GetComponent<PlayerMovement>().hasGold = false; 
            }

        }

        if(collision.collider.tag == "Bcoins" && !player.GetComponent<PlayerMovement>().hasGold)
        {
            Debug.Log("Big Gold");
            player.GetComponent<PlayerMovement>().currentGold += 10; 
            player.GetComponent<PlayerMovement>().hasGold = true;
            player.GetComponent<PlayerMovement>().jumpVelocity = 10;
            player.GetComponent<PlayerMovement>().movementSpeed = 10f; 


        }

        if (collision.collider.tag == "s" && !player.GetComponent<PlayerMovement>().hasGold)
        {
            Debug.Log("Small Gold");
            player.GetComponent<PlayerMovement>().currentGold += 1;
            player.GetComponent<PlayerMovement>().hasGold = true;
            player.GetComponent<PlayerMovement>().jumpVelocity = 18;
            player.GetComponent<PlayerMovement>().movementSpeed = 25f;


        }

        if (collision.collider.tag == "Scoins" && !player.GetComponent<PlayerMovement>().hasGold)
        {
            Debug.Log("Medium Gold");
            player.GetComponent<PlayerMovement>().currentGold += 2;
            player.GetComponent<PlayerMovement>().hasGold = true;
            player.GetComponent<PlayerMovement>().jumpVelocity = 15;
            player.GetComponent<PlayerMovement>().movementSpeed = 20f; ;
        }
    }
}
