using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TemporizadorInGame : MonoBehaviour
{
    public float TiempoTotal;
    public Image Boruto;
    float TiempoRestante;

    void Start()
    {
        TiempoTotal = (float)PlayerPrefs.GetInt("Dificultad") * 60f;
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
            SceneManager.LoadScene("GameOver");
        }
    }
}
