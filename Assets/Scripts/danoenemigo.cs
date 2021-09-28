using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danoenemigo : MonoBehaviour { 
    public bool edamage = false;
    public int salud = 4;
    public ParticleSystem arapu;
    public int damage = 1;
   
    //public Collision hitbox;

    // Use this for initialization
    void Start()
    {
        
    }


    private void OnCollisionEnter(Collision hitbox)
    {
        if (hitbox.gameObject.tag=="Almohada")
        {
            edamage = true;
            salud = salud - damage;
            arapu.Play();

        }
    }

    private void OnCollisionExit(Collision hitbox)
    {
        if (hitbox.gameObject.tag=="Almohada")
        {
            edamage = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(salud==0||salud < 0)
        {
            
            Destroy(gameObject);
        }
    }
}
