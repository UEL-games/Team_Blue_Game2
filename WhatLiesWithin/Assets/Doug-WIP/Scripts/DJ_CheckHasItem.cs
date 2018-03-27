using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_CheckHasItem : MonoBehaviour {

    private bool bl_HasItem;

    public GameObject goCanvas;
    public GameObject goPickupCanvas;

	
	// Update is called once per frame
	void Update () {
        bl_HasItem = DJ_GameManager.bl_HasOfficeKey;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (bl_HasItem)
        {
            goPickupCanvas.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (bl_HasItem)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DJ_GameManager.paused = true;
                goPickupCanvas.SetActive(false);
                goCanvas.SetActive(true);
                DJ_GameManager.bl_HasLetter = true;
                bl_HasItem = false;
            }
        }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                goCanvas.SetActive(false);
            }
    }
    private void OnTriggerExit(Collider other)
    {
        goPickupCanvas.SetActive(false);
    }
}
