using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Carga1 : MonoBehaviour
{
    public float TiempoTotal = 60f;
    public Image Boruto;
    float TiempoRestante;

    void Start()
    {
        TiempoRestante = TiempoTotal;
    }
    
    void Update()
    {
        if(TiempoRestante > 0)
        {
            TiempoRestante -= Time.deltaTime;

            Boruto.fillAmount = TiempoRestante / TiempoTotal;
        }
        else
        {
            SceneManager.LoadScene("SCNLava");
        }
    }
}
