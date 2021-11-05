using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody2D R2D;
    public float Force;
    public float TiempoTotal;
    
    void Start()
    {
        R2D = GetComponent<Rigidbody2D>();
        TiempoTotal = 5f;
    }

    void Update()
    {
        R2D.AddForce(Vector2.up * Force);

        if(TiempoTotal > 0)
        {
            TiempoTotal -= Time.deltaTime;
        }
        else
        {
            TiempoTotal = 5f;
            Hakai();
        }
    }

    private void Hakai()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
    }
}
