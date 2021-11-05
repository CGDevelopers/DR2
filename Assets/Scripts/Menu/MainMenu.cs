using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        if(Video.Ing == false)
        {
            SceneManager.LoadScene("Cinematicas");
        }

        if(Video.Ing == true)
        {
            SceneManager.LoadScene("Cinematica Inglés");
        }
    }

    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void BorrarGuardado ()
    {
        PlayerPrefs.SetInt("Guardado", 0);
    }

    public void Inglés()
    {
        SceneManager.LoadScene("SCNMenuV2 1");
    }

    public void Spanish()
    {
        SceneManager.LoadScene("SCNMenuV2");
    }
}
