using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSceneScript : MonoBehaviour
{
    public void ToMainMenu()
    {
        //SceneManager.LoadScene(0);
    }

    public void BackToGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
