using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_GameManager : MonoBehaviour {

    public static bool bl_InControl;
    public static bool bl_HasPhone;
    public static bool bl_HasOfficeKey;
    public static bool bl_HasLetter;
    public static bool bl_HasSandwich;
    public static bool bl_DroppedSandwich;

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
            bl_InControl = false;
            Cursor.lockState = CursorLockMode.None;
        }
        if (paused == false)
        {
            bl_InControl = true;
            Cursor.lockState = CursorLockMode.Locked;
        }
        #endregion
        #region Debug
        if (Input.GetKey(KeyCode.F10))
        {
            bl_HasPhone = true;
            Debug.Log("Has Phone " + bl_HasPhone);
        }
        if (Input.GetKeyDown(KeyCode.F11))
        {
            bl_HasOfficeKey = true;
            Debug.Log("Has Office Key " + bl_HasOfficeKey);
        }
        if (Input.GetKeyDown(KeyCode.F12))
        {
            bl_HasLetter = true;
            Debug.Log("Has Letter " + bl_HasLetter);
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
            bl_HasSandwich = true;
            Debug.Log("Has Sandwich " + bl_HasSandwich);
        }
        #endregion


    }

}
