using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSlow : MonoBehaviour
{
    MovimientoP2 z2;
    WeaponController wc;
    public float tiempoSlow = 0;
    float velocidadnormal;
    // Start is called before the first frame update
    void Start()
    {
        z2 = FindObjectOfType<MovimientoP2>();
        velocidadnormal = z2.speed;
        wc = FindObjectOfType<WeaponController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Zombie")
        {
            if (tiempoSlow <= 5)
            {
                float reduccion = z2.speed * 0.5f;
                z2.speed = reduccion;
                tiempoSlow++;
            }
            tiempoSlow = 0;
        }



    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Zombie")
        {

            z2.speed = velocidadnormal;


        }
    }
}
