using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinDeLaBeta : MonoBehaviour
{
    public void Backmenu ()
    {
        SceneManager.LoadScene("SCNMenuV2");
    }

    public void RePlayGame ()
    {
        SceneManager.LoadScene("Carga1");
    }

    public void ReQuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
