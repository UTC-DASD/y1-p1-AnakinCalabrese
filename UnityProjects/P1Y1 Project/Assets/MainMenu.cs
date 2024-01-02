using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
public void PlayGame ()
{
SceneManager.LoadScene("PreMainLevel");
}
public void Controls ()
{
SceneManager.LoadScene("Controls menu");
}
public void BackButton ()
{
SceneManager.LoadScene("Title Screen");
}
public void ExitGame ()
{
    Application.Quit();
    Debug.Log("GameQuit");
}
}
