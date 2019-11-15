using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 30f;
    public CharacterController controller;
    public Transform t;
    private float gravity = -9.81f;

    public float air = 100;
    public bool hasGold;

    public int currentGold;
    public int currentScore;
    public int jumpVelocity;

    public Image panelImage;


    Vector3 velocity;

    private void Start()
    {
        hasGold = false;
        currentGold = 0;
        currentScore = 0;
        jumpVelocity = 20;
    }


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * movementSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        stablelizeVelocity();
        checkJump(jumpVelocity);
        checkOutOfMap();
        checkIfDead();

        this.air -= 0.05f; 

    }
    void checkOutOfMap()
    {
        if (t.localPosition.z > 90)
        {
            t.localPosition = new Vector3(t.localPosition.x, t.localPosition.y, -88);
        }

        if (t.localPosition.z < -90)
        {
            t.localPosition = new Vector3(t.localPosition.x, t.localPosition.y, 88);
        }

        if (t.localPosition.x > 86)
        {
            t.localPosition = new Vector3(-84, t.localPosition.y, t.localPosition.z);
        }


        if (t.localPosition.x < -86)
        {
            t.localPosition = new Vector3(84, t.localPosition.y, t.localPosition.z);
        }
    }

    void checkJump(int jumpVelocity)
    {
        if (Input.GetButtonDown("Jump"))
        {
            velocity.y = jumpVelocity;
        }
    }

    void stablelizeVelocity()
    {
        if (velocity.y <= -40)
        {
            velocity.y = -25;
        }
    }

    void setAir(float newAir)
    {
        this.air = newAir;
    }

    void checkIfDead()
    {
        if(air < 0)
        {
            Debug.Log("Oh Dear, You Are Dead");
        }
    }

}
