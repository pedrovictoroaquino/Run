using System;
using UnityEngine;

public class move : MonoBehaviour{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float velo = 500f;


    private void Awake()
    {
        var rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate ()
    {
    
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(velo * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-velo * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
