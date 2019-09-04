using UnityEngine;

public class PlayerMovement : MonoBehaviour { 

    public Rigidbody rb;

    public float forwardsForce;
    public float sidewaysForce;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game start");
    }

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
    }
}
