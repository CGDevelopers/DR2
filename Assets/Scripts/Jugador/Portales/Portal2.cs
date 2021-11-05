using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal2 : MonoBehaviour
{
    public int Save = 0;

    private void OnCollisionEnter2D (Collision2D col)
    {

        if(Save == 0)
        {
            PlayerPrefs.SetInt("Guardado", 0);
        }

        if(col.gameObject.tag == "Player")
        {
            if(PlayerPrefs.GetInt("Guardado") < 2)
            {
            PlayerPrefs.SetInt("Guardado", 2);
            }
        }

        if(col.gameObject.tag == "Player")
        {
            if(Video.Ing == false)
            {
            SceneManager.LoadScene("Carga3");
            }

            if(Video.Ing == true)
            {
            SceneManager.LoadScene("Carga3In");
            }
        }

    }

    void Start()
    {
        Save = PlayerPrefs.GetInt("Guardado");
    }
}
