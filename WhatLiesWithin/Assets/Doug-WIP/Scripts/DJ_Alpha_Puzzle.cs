using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DJ_Alpha_Puzzle : MonoBehaviour
{
    //Delete me
    public int in_button1;
    public int in_b1Answer;
    public bool bl_A1;
    public GameObject go_A1Correct;

    public int in_button2;
    public int in_b2Answer;
    public bool bl_A2;
    public GameObject go_A2Correct;

    public int in_button3;
    public int in_b3Answer;
    public bool bl_A3;
    public GameObject go_A3Correct;

    public int in_button4;
    public int in_b4Answer;
    public bool bl_A4;
    public GameObject go_A4Correct;

    public GameObject TakeKey;
    private bool bl_allRight;
    public GameObject go_keybox_glass;
    public GameObject go_keybox_noglass;
    




    void Update()
    {
        #region KeyBoxB1
        if (DJ_Raycast.st_RaycastHit == "KeyBoxB1")
        {
            in_button1 += in_button1;
            Debug.Log(in_button1);
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
            in_button2 += in_button2;
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
            in_button3 += in_button3;
        }
            if (in_button3 <= 10)
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
            in_button4 += in_button4;
        }
            if (in_button4 <= 10)
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
            Debug.Log("All True");
            bl_allRight = true;
            //go_keybox_glass.SetActive(false);
            Destroy(go_keybox_glass);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (bl_allRight)
        {
            TakeKey.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(TakeKey);
            Destroy(go_keybox_noglass);
            DJ_GameManager.bl_HasOfficeKey = true;
        }
    }
}