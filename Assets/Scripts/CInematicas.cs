using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CInematicas : MonoBehaviour
{
    public GameObject[] O;
    public GameObject tuto;
    public int i;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            O[i].gameObject.SetActive(true);
            i = i+1;

            if(i == 1){
                tuto.gameObject.SetActive(false);
            }

            Debug.Log(i);
        }

        if(i == 4)
        {
            O[0].gameObject.SetActive(false);
            O[1].gameObject.SetActive(false);
            O[2].gameObject.SetActive(false);
        }

        if(i == 6)
        {
            O[3].gameObject.SetActive(false);
            O[4].gameObject.SetActive(false);
        }

        if(i == 8)
        {
            O[5].gameObject.SetActive(false);
            O[6].gameObject.SetActive(false);
        }

        if(i == 11)
        {
            O[9].gameObject.SetActive(false);
            O[8].gameObject.SetActive(false);
            O[7].gameObject.SetActive(false);
        }

        if(i == 14)
        {
            if(Video.Ing == true)
            {
                SceneManager.LoadScene("Carga1In");
            }

            if(Video.Ing == false)
            {
                SceneManager.LoadScene("Carga1");
            }
        }
    }
}
