using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public bool Muerte = false;

    private void tocastelava (Collision2D col)
    {
Muerte = true;
    }
    public void Perdiste ()
    {
        if(Muerte == true){
        SceneManager.LoadScene(1);}
    }

}