using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelector : MonoBehaviour
{
    public Image[] selectionboxes;

    public GameObject[] prefabs;

    void Start()
    {
        foreach (var img in this.selectionboxes)
        {
            img.gameObject.SetActive(false);
        }

        this.Select(0);
    }


    public void Select (int index)
    {
        foreach (var img in this.selectionboxes)
        {
            img.gameObject.SetActive(false);
        }

        this.selectionboxes[index].gameObject.SetActive(true);
        PlayerStorage.pleyerPrefab = this.prefabs[index];
    }

    public void Default()
    {
        PlayerStorage.pleyerPrefab = this.prefabs[0];
    }
}
