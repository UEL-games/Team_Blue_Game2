using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DJ_Alpha_Puzzle : MonoBehaviour
{
    //This script houses the variables for the alpha puzzle - DO NOT EDIT

    [Tooltip("The current number answer 1 is on")]
    public int in_button1 = 0;
    [Tooltip("The correct number for answer 1")]
    public int in_b1Answer;
    [Tooltip("Is answer 1 correct?")]
    public bool bl_A1;
    public GameObject go_A1Correct;
    public Text A1_text;

    [Tooltip("The current number answer 2 is on")]
    public int in_button2 = 0;
    [Tooltip("The correct number for answer 2")]
    public int in_b2Answer;
    [Tooltip("Is answer 2 correct?")]
    public bool bl_A2;
    public GameObject go_A2Correct;
    public Text A2_text;

    [Tooltip("The current number answer 3 is on")]
    public int in_button3 = 0;
    [Tooltip("The correct number for answer 3")]
    public int in_b3Answer;
    [Tooltip("Is answer 3 correct?")]
    public bool bl_A3;
    public GameObject go_A3Correct;
    public Text A3_text;

    [Tooltip("The current number answer 4 is on")]
    public int in_button4 = 0;
    [Tooltip("The correct number for answer 4")]
    public int in_b4Answer;
    [Tooltip("Is answer 4 correct?")]
    public bool bl_A4;
    public GameObject go_A4Correct;
    public Text A4_text;

    public GameObject TakeKey;
    public static bool bl_AlphaallRight;
    public GameObject go_keybox_glass;
    public GameObject go_keybox_noglass;
    




    void Update()
    {
        #region KeyBoxB1
        if (DJ_Raycast.st_RaycastHit == "KeyBoxB1")
        {
            in_button1 += 1;
            DJ_Raycast.st_RaycastHit = "";
            A1_text.text = in_button1.ToString();
        }
        if (in_button1 >= 10)
        {
            in_button1 = 0;
        }
        if (in_button1 == in_b1Answer)
        {
            bl_A1 = true;
            go_A1Correct.SetActive(true);
        }
        else if (in_button1 != in_b1Answer)
        {
            bl_A1 = false;
            go_A1Correct.SetActive(false);
        }
        #endregion
        #region KeyBoxB2
        if (DJ_Raycast.st_RaycastHit == "KeyBoxB2")
        {
            in_button2 += 1;
            DJ_Raycast.st_RaycastHit = "";
            A2_text.text = in_button2.ToString();
        }
        if (in_button2 >= 10)
        {
            in_button2 = 0;
        }
        if (in_button2 == in_b2Answer)
        {
            bl_A2 = true;
            go_A2Correct.SetActive(true);
        }
        else if (in_button2 != in_b2Answer)
        {
            bl_A2 = false;
            go_A2Correct.SetActive(false);
        }
    
        #endregion
        #region KeyBoxB3
        if (DJ_Raycast.st_RaycastHit == "KeyBoxB3")
        {
            in_button3 += 1;
            DJ_Raycast.st_RaycastHit = "";
            A3_text.text = in_button3.ToString();
        }
            if (in_button3 >= 10)
            {
                in_button3 = 0;
            }
            if (in_button3 == in_b3Answer)
            {
                bl_A3 = true;
                go_A3Correct.SetActive(true);
            }
            else if (in_button3 != in_b3Answer)
            {
                bl_A3 = false;
                go_A3Correct.SetActive(false);
            }
        
        #endregion
        #region KeyBoxB4
        if (DJ_Raycast.st_RaycastHit == "KeyBoxB4")
        {
            in_button4 += 1;
            DJ_Raycast.st_RaycastHit = "";
            A4_text.text = in_button4.ToString();
        }
            if (in_button4 >= 10)
            {
                in_button4 = 0;
            }
            if (in_button4 == in_b4Answer)
            {
                bl_A4 = true;
                go_A4Correct.SetActive(true);
            }
            else if (in_button4 != in_b4Answer)
            {
                bl_A4 = false;
                go_A4Correct.SetActive(false);
            }
        
        #endregion
        if (bl_A1 && bl_A2 && bl_A3 && bl_A4)
        {
          //  Debug.Log("All True");
            bl_AlphaallRight = true;
            //go_keybox_glass.SetActive(false);
            Destroy(go_keybox_glass);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (bl_AlphaallRight)
        {
            TakeKey.SetActive(true);
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (bl_AlphaallRight)
        {
            TakeKey.SetActive(true);
        }


        if ((Input.GetKey(KeyCode.E)) && (bl_AlphaallRight))
        {
            //Debug.Log("Pressing E");
            TakeKey.SetActive(false);
            Destroy(go_keybox_noglass);
            DJ_GameManager.bl_HasOfficeKey = true;
            Destroy(this);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        TakeKey.SetActive(false);
    }
}