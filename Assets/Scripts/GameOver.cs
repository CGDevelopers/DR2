using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string NameScene;

    private void OnCollisionEnter2D (Collision2D col)
    {

        if(col.gameObject.tag == "Player")
        {
            NameScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(NameScene);
        }

    }

}