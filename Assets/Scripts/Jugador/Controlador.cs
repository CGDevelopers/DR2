using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    private static Controlador instance;
    public Vector2 CheckPointActual;
       
    void Awake()
    {
        if(instance == null)
        {
            instance=this;
            DontDestroyOnLoad(instance);
        }else{
            Destroy(gameObject);
        }
    }
}
