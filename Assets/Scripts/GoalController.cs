using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public bool isP1;
    public bool isP2;
    public bool isP3;
    public bool isP4;
    public ScoreManager scoremanager;
    //private int loseAmount = 0;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "bola")
        {
            if (isP1 == true)
            {
                scoremanager.AddScoreP1(1);
                //manager.TheWinner("Player 1");
            }
            else if (isP2 == true)
            {
                scoremanager.AddScoreP2(1);
                //manager.TheWinner("Player 2");

            }
            else if (isP3 == true)
            {
                scoremanager.AddScoreP3(1);
                //manager.TheWinner("Player 3");

            }
            else if (isP4 == true)
            {
                scoremanager.AddScoreP4(1);
                //manager.TheWinner("Player 4");

            }
        }
    }
    //public void theWinner()
    //{
    //    manager.Winner();
    //}
}
