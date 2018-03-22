using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_GameManager : MonoBehaviour {

    public static bool bl_HasPhone;
    public static bool bl_HasOfficeKey;
    public bool paused = false;
    


    private void Awake()
    {
     //Makes Cursor Disappear
     Cursor.lockState = CursorLockMode.Locked;
    }
   
	void FixedUpdate () {

        if (bl_HasPhone)
        {
            Debug.Log("HAS PHONE!");
        }

        #region Pause
        //Pauses Game
        if ((Input.GetKeyDown(KeyCode.Escape)) &&(paused == false))
        {
            paused = true;
            
        }
        //Unpauses Game
       else if ((Input.GetKeyDown(KeyCode.Escape) && (paused == true)))
        {
            paused = false;

        }
        Debug.Log(paused);

        if (paused)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if (!paused)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        #endregion


    }

}
