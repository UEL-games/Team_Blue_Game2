using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    public void Start()
    {
        //Application.Quit();
        //print("Quitted");
    }

    // Use this for initialization
    public void Quitting()
    {

        // attach to canvus and go unfer finsish game > quitting
        // this section start the game (loads to which ever level

        Application.Quit();
        print("Quitted");
    }
    public void StartGame()

        // attach to canvus and go unfer finsish game > start
        // this section start the game (loads to which ever level)
    {
        SceneManager.LoadScene("Scene 1");
        print("Quitted");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clicked()
    {
        print("Quitted");
    }
}
