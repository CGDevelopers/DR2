using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal4 : MonoBehaviour
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
            if(PlayerPrefs.GetInt("Guardado") < 4)
            {
            PlayerPrefs.SetInt("Guardado", 4);
            }
        }

        if(col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Creditos");
        }

    }

    void Start()
    {
        Save = PlayerPrefs.GetInt("Guardado");
    }
}
