using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("MainGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
