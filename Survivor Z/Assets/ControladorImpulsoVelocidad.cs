using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorImpulsoVelocidad : MonoBehaviour
{
    // Start is called before the first frame update
    public float fuerzaImpulso = 3;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Rigidbody2D>() != null)
        {
            other.GetComponent<Rigidbody2D>().AddForce(transform.up * fuerzaImpulso, ForceMode2D.Impulse);
        }

    }

}

