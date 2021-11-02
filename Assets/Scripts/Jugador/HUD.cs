using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    public float TiempoTotal;
    public Image Boruto;
    float TiempoRestante;
    private Character Personaje;
    public GameObject PrimeraVida;
    public GameObject SegundaVida;
    public GameObject TerceraVida;
    public int vida;

    void Start()
    {
        TiempoTotal = (float)PlayerPrefs.GetInt("Dificultad") * 60f;
        TiempoRestante = TiempoTotal;
        Personaje = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
    }
    
    void Update()
    {
        vida = Character.vida;

        if(TiempoRestante > 0)
        {
            TiempoRestante -= Time.deltaTime;

            Boruto.fillAmount = TiempoRestante / TiempoTotal;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }

        if(vida < 3)
        {
            PrimeraVida.SetActive(false);
        }

        if(vida < 2)
        {
            SegundaVida.SetActive(false);
        }

        if(vida < 1)
        {
            TerceraVida.SetActive(false);
        }

    }
}
