using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_Raycast : MonoBehaviour {

    public static string st_RaycastHit;

    void Update()
    {

        RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
        {
            st_RaycastHit = hit.collider.gameObject.name;
            Debug.Log(st_RaycastHit);
        }
    }
}
