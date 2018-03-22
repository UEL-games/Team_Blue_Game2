using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DJ_Alpha_Puzzle : MonoBehaviour
{

    static public int in_button1;
    public int in_b1Answer;
    public bool bl_A1;
    public int in_button2;
    public int in_button3;
    public int in_button4;

    public GameObject go_keybox;
    public GameObject go_A1Correct;



    // Update is called once per frame
    void Update()
    {
        if (in_button1 >= 10)
        {
            in_button1 = 0;
        }
        if (in_button1 == in_b1Answer)
        {
            bl_A1 = true;
            go_A1Correct.SetActive(true);
        }
        else if (in_button1  != in_b1Answer)
        {
            bl_A1 = false;
            go_A1Correct.SetActive(false);
        }
        


    }
}