using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoadWin;
    public string sceneToLoadLose;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoadWin);
        }
        else if (col.tag == "Car")
        {
            SceneManager.LoadScene(sceneToLoadLose);
        }
    }
}
