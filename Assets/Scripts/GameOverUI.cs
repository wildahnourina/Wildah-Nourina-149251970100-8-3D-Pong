using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverUI : MonoBehaviour
{
    public Text theWinner;

    public ScoreManager manager;
    //Enemy enemy = other.gameObject.GetComponent<Enemy>();

    void Update()
    {
        //ScoreManager manager = GetComponent<ScoreManager>();
        theWinner.text = manager.winner;
    }
    
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
