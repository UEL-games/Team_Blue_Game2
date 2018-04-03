using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_OnCollideSpawn : MonoBehaviour {

    public GameObject go_ObjecttoSpawn;

    private void OnTriggerEnter(Collider other)
    {
        go_ObjecttoSpawn.SetActive(true);
    }
}
