using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muertos : MonoBehaviour {
    public Collider barrera;

	// Use this for initialization
	void Start () {
        barrera.enabled = true;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindWithTag("Enemigos"))
            {
            barrera.enabled = true;
        }
        else
        {
            barrera.enabled = false;
        }


    }
}
