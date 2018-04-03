using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_Computer_Puzzle : MonoBehaviour {

    public GameObject go_screen1;
    public GameObject go_screen2;
    public GameObject go_screen3;
    public GameObject go_screen4;

    public float fl_loadingtimer;
    private float fl_starttime;
    private bool bl_S1destroyed;

	
	// Update is called once per frame
	void Update () {


        if (DJ_Raycast.st_RaycastHit == "Screen1")
        {
            Destroy(go_screen1);
            fl_loadingtimer += Time.deltaTime;
            
        }
        if ((fl_loadingtimer >= 3) && (bl_S1destroyed == false))
        {
            Destroy(go_screen2);
            fl_loadingtimer = 0;
            bl_S1destroyed = true;
           
        }
        if (DJ_Raycast.st_RaycastHit == "Screen3")
        {
            Destroy(go_screen3);
            fl_loadingtimer += Time.deltaTime;

        }
        if ((fl_loadingtimer >= 5) && (DJ_Raycast.st_RaycastHit == "Screen3"))
        {
            Destroy(go_screen4);
        }
		
	}
}
