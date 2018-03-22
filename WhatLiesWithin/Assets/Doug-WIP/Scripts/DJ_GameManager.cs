using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_GameManager : MonoBehaviour {

    public static bool bl_InControl;
    public static bool bl_HasPhone;
    public static bool bl_HasOfficeKey;

    public static bool paused = false;
    


    private void Awake()
    {
        bl_InControl = true;
     //Makes Cursor Disappear
     Cursor.lockState = CursorLockMode.Locked;
    }
   
	void FixedUpdate () {

        

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
      //  Debug.Log(paused);

        if (paused)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if (paused == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        #endregion
        #region Debug
        if (Input.GetKey(KeyCode.F10))
        {
            bl_HasPhone = true;
        }
        if (Input.GetKeyDown(KeyCode.F11))
        {
            bl_HasOfficeKey = true;
        }
        #endregion


    }

}
