using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dificultad : MonoBehaviour
{
    public void Facil ()
    {
        PlayerPrefs.SetInt("Dificultad", 3);
    }

    public void Medio ()
    {
        PlayerPrefs.SetInt("Dificultad", 2);
    }

    public void Dificil ()
    {
        PlayerPrefs.SetInt("Dificultad", 1);
    }

}