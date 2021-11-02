using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public float TiempoTotal;

    void Update()
    {

        if(TiempoTotal > 0)
        {
            TiempoTotal -= Time.deltaTime;
        }
        else
        {
            TiempoTotal = 3f;
            shoot();
        }

    }

    void shoot()
    {
        Instantiate(bullet, this.transform.position, Quaternion.identity);
    }
}
