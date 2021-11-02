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
            SceneManager.LoadScene("SCNMenuV2");
        }

    }

    public void Update()
    {
        Save = PlayerPrefs.GetInt("Guardado");
    }
}
