using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_Pickup : MonoBehaviour {

    
    private bool bl_objectPickup;

    private void OnTriggerStay(Collider col)
    {
        if ((col.gameObject.tag == "Player")
            && (Input.GetKeyDown(KeyCode.E)))
        {
            Debug.Log("Picked Up");
            bl_objectPickup = true;
            Destroy(gameObject);
        }

     //   Insert static bool here = bl_objectPickup;
    }
}
