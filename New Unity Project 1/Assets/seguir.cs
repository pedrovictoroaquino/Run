using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguir : MonoBehaviour {

    public Transform player;
    public Vector3 movimento;

	void Update()
    {

        transform.position = player.position + movimento;

    }
}
