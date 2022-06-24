using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text player1;
    public Text player2;
    public Text player3;
    public Text player4;

    public ScoreManager manager;

    void Update()
    {
        player1.text = manager.player1score.ToString();
        player2.text = manager.player2score.ToString();
        player3.text = manager.player3score.ToString();
        player4.text = manager.player4score.ToString();
    }
}
