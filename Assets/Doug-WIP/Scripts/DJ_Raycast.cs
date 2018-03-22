using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJ_Raycast : MonoBehaviour {


    void Update()
    {

        RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
        {
            if (hit.transform.name == "KeyBoxB1")
            {
                DJ_Alpha_Puzzle.in_button1 += DJ_Alpha_Puzzle.in_button1;
                Debug.Log(DJ_Alpha_Puzzle.in_button1);

            }
            /*
            if (hit.transform.name == "KeyBoxB2")
            {
                in_button2 += in_button2;
                if (in_button2 <= 10)
                {
                    in_button2 = 0;
                }
            }
            if (hit.transform.name == "KeyBoxB3")
            {
                in_button3 += in_button3;
                if (in_button3 <= 10)
                {
                    in_button3 = 0;
                }
            }
            if (hit.transform.name == "KeyBoxB4")
            {
                in_button4 += in_button4;
                if (in_button4 <= 10)
                {
                    in_button4 = 0;
                }
            }*/
        }
    }
}
