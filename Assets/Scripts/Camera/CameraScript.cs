using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Vlad;

    void Update()
    {
        if (Vlad != null)
        {
            Vector3 position = transform.position;
            position.x = Vlad.transform.position.x;
            transform.position = position;
        }
    }
}