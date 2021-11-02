using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorNiveles : MonoBehaviour
{
    public void SeleccionarLava (){
        SceneManager.LoadScene("Carga1");

        PlayerPrefs.SetInt("TemporizadorNivel", PlayerPrefs.GetInt("Dificultad")*60);
    }

    public void SeleccionarJungla (){
        PlayerPrefs.SetInt("TemporizadorNivel", PlayerPrefs.GetInt("Dificultad")*60);
        
        SceneManager.LoadScene("Carga2");
    }
}
