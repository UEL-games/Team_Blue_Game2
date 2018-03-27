using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_ChangeCamera : MonoBehaviour {

    public Camera newCamera;
    public Camera oldCamera;
    public bool bl_camerachanged;
    public GameObject go_canvas;

	// Use this for initialization
	void Start () {
        newCamera = GetComponentInChildren<Camera>();
        newCamera.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (DJ_Alpha_Puzzle.bl_AlphaallRight)
        {
            bl_camerachanged = false;
            oldCamera.enabled = true;
            newCamera.enabled = false;
            DJ_GameManager.bl_InControl = true;
            Cursor.lockState = CursorLockMode.Locked;
            go_canvas.SetActive(false);
        }
		
	}

    private void OnTriggerEnter(Collider other)
    {
        oldCamera = other.GetComponentInChildren<Camera>();
    }

    private void OnTriggerStay(Collider other)
    {
        if ((Input.GetKeyDown(KeyCode.E)) &&(bl_camerachanged == false))
        {
            bl_camerachanged = true;
            oldCamera.enabled = false;
            newCamera.enabled = true;
            DJ_GameManager.bl_InControl = false;
            DJ_GameManager.paused = true;
            go_canvas.SetActive(true);
        }
        if ((Input.GetKeyDown(KeyCode.Escape)) && (bl_camerachanged == true))
        {
            bl_camerachanged = false;
            oldCamera.enabled = true;
            newCamera.enabled = false;
            DJ_GameManager.bl_InControl = true;
            DJ_GameManager.paused = false;
            go_canvas.SetActive(false);
        }
    }
}
