using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public string NameScene;
    public int vidas = PlayerPrefs.GetInt("Vidas");

    void Start ()
    {
        NameScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("CargaNivel", NameScene);
    }

    private void OnCollisionEnter2D (Collision2D col)
    {

        if(col.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("Vidas", vidas-1);
            SceneManager.LoadScene(NameScene);
        }
        
        if (PlayerPrefs.GetInt("Vidas") == 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
    
}