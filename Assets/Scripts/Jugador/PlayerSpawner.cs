using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    void Start()
    {
        Instantiate(PlayerStorage.pleyerPrefab, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
