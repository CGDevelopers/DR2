using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    private bool active;
    Canvas canvas;
    public string NameScene;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;    
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
        SceneManager.LoadScene("SCNMenuV2");
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
