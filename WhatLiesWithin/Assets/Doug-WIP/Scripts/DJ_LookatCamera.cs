using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_LookatCamera : MonoBehaviour {

    [Tooltip("The Place you want the object to look at")]
    public Camera ca_LookHere;


	// Update is called once per frame
	void Update () {

        Vector3 v = ca_LookHere.transform.position - transform.position;

        v.x = v.z = 0.0f;

        transform.LookAt(ca_LookHere.transform.position - v);
        transform.Rotate(0, 180, 0);
		

    }
}
