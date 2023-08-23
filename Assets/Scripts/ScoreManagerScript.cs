using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManagerScript : MonoBehaviour
{
    public int scoreToReach;
    private int player1Score = 0;
    private int player2Score = 0;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    public void player1Goal()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
        CheckScore();
    }
    public void player2Goal()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString(); 
        CheckScore() ;
    }
    private void CheckScore()
    {
        if(player1Score == scoreToReach ||  player2Score == scoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }
}
