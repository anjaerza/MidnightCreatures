using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoBase : MonoBehaviour {
    public Collider detectar;
    public bool activo = false;
    public Transform target;
    public float speed;
    public Animator anima;
    // Use this for initialization
    void Start()
    {
        anima= GetComponent<Animator>();

    }


    private void OnTriggerEnter(Collider detectar)
    {
        if (detectar.CompareTag("Player"))
        {
            activo = true;   
        }

        
    }
    void Update()
    {
        if (activo)
        {
            Vector3 totarget = target.transform.position - transform.position;
            speed = 0.3f;
            transform.Translate(totarget * speed * Time.deltaTime);
            anima.SetBool("mueve", true);
        }
        else
        {
            anima.SetBool("mueve", false);
        }
    }
}

