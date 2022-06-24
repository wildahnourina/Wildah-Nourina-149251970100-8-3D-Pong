using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int player1score;
    public int player2score;
    public int player3score;
    public int player4score;
    public int maxscore;

    public BallController bola;

    public GameObject paddle1;
    public GameObject paddle2;
    public GameObject paddle3;
    public GameObject paddle4;

    public GameObject gawang1;
    public GameObject gawang2;
    public GameObject gawang3;
    public GameObject gawang4;

    private int loseAmount = 0;
    public string winner;

    public GameObject GameOverUI;

    void Start()
    {
        winner = PlayerPrefs.GetString("ScoreManager");
    }

    void Update()
    {
        PlayerPrefs.SetString("ScoreManager", winner);
    }

    public void AddScoreP1(int increment)
    {

        player1score += increment;
        //bola.ResetBall();
        if (player1score >= maxscore)
        {
            Destroy(paddle1);
            Destroy(gawang1);
            loseAmount = loseAmount + 1;
        }
        Winner();
    }

    public void AddScoreP2(int increment)
    {

        player2score += increment;
        //bola.ResetBall();
        if (player2score >= maxscore)
        {
            Destroy(paddle2);
            Destroy(gawang2);
            loseAmount = loseAmount + 1;
        }
        Winner();
    }

    public void AddScoreP3(int increment)
    {

        player3score += increment;
        //bola.ResetBall();
        if (player3score >= maxscore)
        {
            Destroy(paddle3);
            Destroy(gawang3);
            loseAmount = loseAmount + 1;
        }
        Winner();
    }

    public void AddScoreP4(int increment)
    {
        player4score += increment;
        //bola.ResetBall();
        if (player4score >= maxscore)
        {
            Destroy(paddle4);
            Destroy(gawang4);
            loseAmount = loseAmount + 1;
        }
        Winner();
    }

    public void Winner()
    {
        if (loseAmount == 3)
        {
            if(player1score >= 0 && player1score < maxscore)
            {
                winner = "Player 1";
                TheWinner();
            }
            else if (player2score >= 0 && player2score < maxscore)
            {
                winner = "Player 2";
                TheWinner();
            }
            else if (player3score >= 0 && player3score < maxscore)
            {
                winner = "Player 3";
                TheWinner();
            }
            else if (player4score >= 0 && player4score < maxscore)
            {
                winner = "Player 4";
                TheWinner();
            }
        }
    }

    public void TheWinner()    
    {
        GameOverUI.SetActive(true);
    }
}
