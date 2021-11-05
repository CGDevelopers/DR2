using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal3: MonoBehaviour
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
            if(PlayerPrefs.GetInt("Guardado") < 3)
            {
            PlayerPrefs.SetInt("Guardado", 3);
            }
        }

        if(col.gameObject.tag == "Player")
        {
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

    void Start()
    {
        Save = PlayerPrefs.GetInt("Guardado");
    }
}
