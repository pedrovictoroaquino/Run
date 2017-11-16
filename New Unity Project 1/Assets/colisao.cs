using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisao : MonoBehaviour {

    public move movement;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "obstacle")
        {

            movement.enabled = false;

        }
    }

}
