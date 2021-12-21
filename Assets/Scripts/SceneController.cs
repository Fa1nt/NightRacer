using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void doExitGame()
    {
        Application.Quit();
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
