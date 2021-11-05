using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pausa : MonoBehaviour
{
    private bool active;
    Canvas canvas;
    public static string NameScene;

    public GameObject[] Esp;
    public GameObject[] Ing;

    void Start()
    {

        NameScene = SceneManager.GetActiveScene().name;
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;  

        if(Video.Ing == true)
        {
            Esp[0].gameObject.SetActive(false);
            Esp[1].gameObject.SetActive(false);
            Esp[2].gameObject.SetActive(false);
            Esp[3].gameObject.SetActive(false);
        }

        if(Video.Ing == false)
        {
            Ing[0].gameObject.SetActive(false);
            Ing[1].gameObject.SetActive(false);
            Ing[2].gameObject.SetActive(false);
            Ing[3].gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown("escape")){
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
        }
    }
    
    public void Menu ()
    {
        if(Video.Ing == false)
        {
        SceneManager.LoadScene("SCNMenuV2");
        }
        if(Video.Ing == true)
        {
        SceneManager.LoadScene("SCNMenuV2 1");
        }
    }

    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void Reinicio ()
    {
        NameScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(NameScene);
        active = !active;
        Time.timeScale = (active) ? 0 : 1f;
    }
}
