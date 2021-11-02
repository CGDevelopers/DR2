using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Backmenu ()
    {
        SceneManager.LoadScene("SCNMenuV2");
    }

    public void RePlayGame ()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("CargaNivel"));
    }

    public void ReQuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
