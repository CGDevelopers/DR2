using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candados : MonoBehaviour
{
    public GameObject Candado1;
    public GameObject Candado2;
    public GameObject Candado3;
    public GameObject Candado4;
            

    public void Update ()
    {
        if(PlayerPrefs.GetInt("Guardado") >= 1){
            Candado1.SetActive(false);
        }
        
        if(PlayerPrefs.GetInt("Guardado") >= 2){
            Candado2.SetActive(false);
        }

        if(PlayerPrefs.GetInt("Guardado") >= 3){
            Candado3.SetActive(false);
        }

        if(PlayerPrefs.GetInt("Guardado") >= 4){
            Candado4.SetActive(false);
        }
    }
}
