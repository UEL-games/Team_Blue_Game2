using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangingScenes : MonoBehaviour
{

    // public string allows any scene can aplied
    // scenes don't need futher scripts to transfer

    public string SceneName;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    // making sure colliders work
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.transform.tag == "Player")
        {
            print("Change Scenes");
            SceneManager.LoadScene(SceneName);
        }
    }
}
