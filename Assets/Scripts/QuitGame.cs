using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene("Test");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
