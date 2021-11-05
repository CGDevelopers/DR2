using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movedizas : MonoBehaviour
{
    private Rigidbody2D R2D;
    public float Force;
    public bool estado;
    public float Ty;

    void Start()
    {
        R2D = GetComponent<Rigidbody2D>();
       
    }

    void Update()
    {
         Ty = this.transform.position.y;


        if(Ty >= 3)
        {
            estado = true;
        }

        if(Ty <= -5)
        {
            estado = false;
        }

        if(estado == true)
        {
            IrHaciaAbajo();
        }
        
        if(estado == false)
        {
            IrHaciaArriba();
        }
    }

    void IrHaciaAbajo()
    {
        R2D.AddForce(Vector2.down * Force);
    }

    void IrHaciaArriba()
    {
        R2D.AddForce(Vector2.up * Force);
    }
}
