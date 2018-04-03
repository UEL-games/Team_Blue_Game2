using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_DropoffSandwich : MonoBehaviour {

    public GameObject go_canvas;

    private void OnTriggerEnter(Collider other)
    {
        if (DJ_GameManager.bl_HasSandwich)
        {
            go_canvas.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (DJ_GameManager.bl_HasSandwich)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {           
                DJ_GameManager.bl_DroppedSandwich = true;
                Debug.Log("Dropped Sandwich " + DJ_GameManager.bl_DroppedSandwich);
                go_canvas.SetActive(false);
                Destroy(this);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        go_canvas.SetActive(false);
    }
}
