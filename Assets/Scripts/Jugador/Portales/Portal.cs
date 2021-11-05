using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
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
            if(PlayerPrefs.GetInt("Guardado") < 1)
            {
            PlayerPrefs.SetInt("Guardado", 1);
            }
        }

        if(col.gameObject.tag == "Player")
        {
            if(Video.Ing == false)
            {
            SceneManager.LoadScene("Carga2");
            }

            if(Video.Ing == true)
            {
            SceneManager.LoadScene("Carga2In");
            }
        }

    }

    void Start()
    {
        Save = PlayerPrefs.GetInt("Guardado");
    }
}
