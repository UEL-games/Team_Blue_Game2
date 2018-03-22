using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DJ_Inventory : MonoBehaviour {
    //Delete me

    public GameObject ca_invUI;
    public RawImage ri_Key;

    bool bl_invOpen = false;
    bool bl_HasPhone;
    
	
	
	void Update () {
        bl_HasPhone = DJ_GameManager.bl_HasPhone;

        if (bl_HasPhone)
        {
            if (DJ_GameManager.bl_HasOfficeKey)
            {
                ri_Key.gameObject.SetActive(true);
            }

            if ((Input.GetKeyDown(KeyCode.I)) && (bl_invOpen == false))
            {
                ca_invUI.SetActive(true);
                bl_invOpen = true;
                Time.timeScale = 0.0f;
                Cursor.lockState = CursorLockMode.None;
            }
            else if ((Input.GetKeyDown(KeyCode.I)) && (bl_invOpen == true))
            {
                ca_invUI.SetActive(false);
                bl_invOpen = false;
                Time.timeScale = 1.0f;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
		
	}
}
