using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("How To Play");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
