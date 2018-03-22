using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_Phone_Pickup_Alpha : MonoBehaviour {

    

    private void OnTriggerStay(Collider col)
    {
        if ((col.gameObject.tag == "Player") 
            && (Input.GetKeyDown(KeyCode.E)))
        {
            Debug.Log("In Phone Area");
            DJ_GameManager.bl_HasPhone = true;
            Destroy(gameObject);
        }
    }
}
