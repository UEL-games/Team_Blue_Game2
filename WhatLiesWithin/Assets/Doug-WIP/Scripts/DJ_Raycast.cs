using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_Raycast : MonoBehaviour {
    //This code is used to select something with the mouse, when placed on an object anything clicked FROM that object will write the name of the object to st_RaycastHit

    public static string st_RaycastHit;
    public Camera mCam;

    void Start()
    {
        mCam = GetComponent<Camera>();
    }

    void Update()
    {
        Ray tRay = mCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(tRay, out hit, 100))//transform.position, -Vector3.up, out hit))
            {
                st_RaycastHit = hit.collider.gameObject.name;
               // Debug.Log(st_RaycastHit);
                Debug.DrawLine(tRay.origin, hit.point);
            }
            Debug.Log(st_RaycastHit);

        }
    }
}
