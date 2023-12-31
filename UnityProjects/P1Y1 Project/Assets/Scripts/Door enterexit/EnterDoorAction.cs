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
            sceneToLoad = "Title Screen";
            enterAllowed = true;
        }
         else if (collision.GetComponent<EntranceDoor1>())
        {
            sceneToLoad = "MainLevel 3";
            enterAllowed = true;
        }
         else if (collision.GetComponent<EntranceDoor2>())
        {
            sceneToLoad = "MainLevel 4";
            enterAllowed = true;
        }
         else if (collision.GetComponent<EntranceDoor3>())
        {
            sceneToLoad = "MainLevel 5";
            enterAllowed = true;
        } else if (collision.GetComponent<EntranceDoor4>())
        {
            sceneToLoad = "MainLevel 6";
            enterAllowed = true;
        }   else if (collision.GetComponent<EntranceDoorPRE>())
        {
            sceneToLoad = "MainLevel";
            enterAllowed = true;
        }else if (collision.GetComponent<EntranceDoor5>())
        {
            sceneToLoad = "MainLevel 7";
            enterAllowed = true;
        }else if (collision.GetComponent<EntranceDoor6>())
        {
            sceneToLoad = "MainLevel 8";
            enterAllowed = true;
        }else if (collision.GetComponent<EntranceDoor7>())
        {
            sceneToLoad = "MainLevel 9";
            enterAllowed = true;
        }else if (collision.GetComponent<EndDoor>())
        {
            sceneToLoad = "X End Screen";
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