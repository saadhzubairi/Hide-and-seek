using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score;
    public float time;
    public static GameManager instance;
    public Text scoreText;
    public Text timeText;

    private void Awake()
    {
        instance = this;
    }

    public void incrementScore()
    {
        score++;
        scoreText.text = "Score: "+score.ToString()+"/6";
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeText.text = "Time Left: " + (int)time;
        if(time <= 0)
        {
            print("You lose");
        }
        if(score == 6)
        {
            print("You win");
        }
        
    }
}
