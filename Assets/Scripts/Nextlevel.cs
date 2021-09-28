﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour {


    public string level;
    public Collider other;
    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(level);
        }
    }
}
