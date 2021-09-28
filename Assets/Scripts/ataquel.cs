using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataquel : MonoBehaviour {
    public Animator anim;
    public CapsuleCollider cc;
    public AudioSource soni;
	// Use this for initialization
	void Start () {
        cc.enabled = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("ataque", true);
            cc.enabled = true;
            soni.Play();
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("ataque", false);
            cc.enabled = false;
        }
    }
}
