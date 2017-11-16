using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    

    void Update () {
        float value = player.position.z;
        var valor = value / 5;
        scoreText.text = valor.ToString("0");
	}
}
