using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoorAction : MonoBehaviour
{
      private bool enterAllowed;
    private string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EntranceDoor>())
        {
            sceneToLoad = "MainLevel 2";
            enterAllowed = true;
        }
        else if (collision.GetComponent<ExitDoor>())
        {
            sceneToLoad = "MainLevel";
            enterAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<EntranceDoor>() || collision.GetComponent<ExitDoor>())
        {
            enterAllowed = false;
        }
    }

    private void Update()
    {
        if (enterAllowed && Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}