using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    public GameObject[] Esp;
    public GameObject[] Ing;
    public float TiempoTotal;
    public Image Boruto;
    float TiempoRestante;

    void Start()
    {
        if(Video.Ing == true)
        {
            Esp[0].gameObject.SetActive(false);
            Esp[1].gameObject.SetActive(false);
            Esp[2].gameObject.SetActive(false);
            Esp[3].gameObject.SetActive(false);
        }

        if(Video.Ing == false)
        {
            Ing[0].gameObject.SetActive(false);
            Ing[1].gameObject.SetActive(false);
            Ing[2].gameObject.SetActive(false);
            Ing[3].gameObject.SetActive(false);
        }
        
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
            if(Video.Ing == true)
            {
                SceneManager.LoadScene("SCNMenuV2 1");
            }

            if(Video.Ing == false)
            {
                SceneManager.LoadScene("SCNMenuV2");
            } 
        }
    }
}

