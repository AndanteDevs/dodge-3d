﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour { 

    public Rigidbody rb;

    public float forwardsForce = 200f;
    public float sidewaysForce = 50f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardsForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( rb.position.y < -1 )
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
