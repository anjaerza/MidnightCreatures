using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class danoju : MonoBehaviour
{
    public bool daño;
    public int vida = 6;
    public ParticleSystem jugapuf;
    public int damage=1;


    private void OnTriggerEnter(Collider jugador)
    {
        if (jugador.CompareTag("Enemigos"))
        {
            daño = true;
            vida = vida - damage;
            jugapuf.Play();
        }
    }

    private void OnTriggerExit(Collider jugador)
    {
        if (jugador.CompareTag("Enemigos"))
        {
            daño = false;
        }
    }
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (vida == 0 || vida < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }


}