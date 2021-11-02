using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{

    private Controlador gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<Controlador>();
    }

    void OnTriggerEnter2D(Collider2D ChP)
   {

       if(ChP.CompareTag("Player"))
       {
          gm.CheckPointActual = transform.position;
       }

   }
}
