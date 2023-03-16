using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        List<ScoreManager.ScoreEntry> topScores = scoreManager.GetTopScores();
        string scoreString = "TOP SCORES:\n";
        for (int i = 0; i < topScores.Count; i++)
        {
            scoreString += (i + 1) + ". " + topScores[i].name + ": " + topScores[i].score + "\n";
        }
        scoreText.text = scoreString;
        
    }
}
