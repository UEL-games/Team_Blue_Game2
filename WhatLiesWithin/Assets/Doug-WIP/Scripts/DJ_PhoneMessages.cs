using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_PhoneMessages : MonoBehaviour {

    public GameObject go_Text1;
    public GameObject go_Text2;
	
	void Update () {
        if (DJ_GameManager.bl_HasPhone)
        {
            go_Text1.SetActive(true);
            go_Text2.SetActive(false);
        }
        if (DJ_GameManager.bl_DroppedSandwich)
        {
            go_Text2.SetActive(true);
            go_Text1.SetActive(false);
        }
		
	}
}
