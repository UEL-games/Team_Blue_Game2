using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DJ_Inventory : MonoBehaviour {
    //Delete me
    [Tooltip("Inventory Canvas - Image of phone")]
    public GameObject ca_invUI;
    [Tooltip("Image file of the key")]
    public RawImage ri_Key;
    [Tooltip("Image for the Document")]
    public RawImage ri_Document;
    [Tooltip("The button used to open/close inventory")]
    public KeyCode key_inventoryButton;

    private bool bl_invOpen = false;
    
	
	
	void Update () {  

        if (DJ_GameManager.bl_HasPhone)
        {
            if (DJ_GameManager.bl_HasOfficeKey)
            {
                ri_Key.gameObject.SetActive(true);
            }
            if (DJ_GameManager.bl_HasLetter)
            {
                ri_Document.gameObject.SetActive(true);
            }

            if ((Input.GetKeyDown(key_inventoryButton)) && (bl_invOpen == false))
            {
                ca_invUI.SetActive(true);
                bl_invOpen = true;
                Time.timeScale = 0.0f;
                Cursor.lockState = CursorLockMode.None;
            }
            else if ((Input.GetKeyDown(key_inventoryButton)) && (bl_invOpen == true))
            {
                ca_invUI.SetActive(false);
                bl_invOpen = false;
                Time.timeScale = 1.0f;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
		
	}
}
