using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_OnCollidePickup : MonoBehaviour {

    public GameObject go_canvas;

    private void OnTriggerEnter(Collider other)
    {
        go_canvas.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            go_canvas.SetActive(false);
            DJ_GameManager.bl_HasSandwich = true;
            Debug.Log("Picked up Sandwich");
            Destroy(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        go_canvas.SetActive(false);
    }
}
