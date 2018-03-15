using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void Start()
    {
        Application.Quit();
        print("Quitted");
    }

    // Use this for initialization
    public void Quitting()
    {
        Application.Quit();
        print("Quitted");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Clicked()
    {
        print("Quitted");
    }
}
