using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorNiveles : MonoBehaviour
{
    public void SeleccionarLava ()
    {

        PlayerPrefs.SetInt("TemporizadorNivel", PlayerPrefs.GetInt("Dificultad")*90);

        if(Video.Ing == false)
        {
            SceneManager.LoadScene("Cinematicas");
        }

        if(Video.Ing == true)
        {
            SceneManager.LoadScene("Cinematica Inglés");
        }
    }

    public void SeleccionarJungla ()
    {

        PlayerPrefs.SetInt("TemporizadorNivel", PlayerPrefs.GetInt("Dificultad")*90);

        if(Video.Ing == false)
        {
            SceneManager.LoadScene("Carga2");
        }

        if(Video.Ing == true)
        {
            SceneManager.LoadScene("Carga2In");
        }
    }

    public void SeleccionarDesierto ()
    {

        PlayerPrefs.SetInt("TemporizadorNivel", PlayerPrefs.GetInt("Dificultad")*90);
        
        if(Video.Ing == false)
        {
            SceneManager.LoadScene("Carga3");
        }

        if(Video.Ing == true)
        {
            SceneManager.LoadScene("Carga3In");
        }
    }

    public void SeleccionarLaboratiorio ()
    {

        PlayerPrefs.SetInt("TemporizadorNivel", PlayerPrefs.GetInt("Dificultad")*90);
        
        if(Video.Ing == false)
        {
            SceneManager.LoadScene("Carga4");
        }

        if(Video.Ing == true)
        {
            SceneManager.LoadScene("Carga4In");
        }
    }
}