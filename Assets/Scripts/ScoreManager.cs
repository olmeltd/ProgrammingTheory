using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreboardText;
    public int maxScores = 10;

    private List<PlayerScore> scores = new List<PlayerScore>();

    [System.Serializable]
    public class PlayerScore
    {
        public string name;
        public int score;
    }

    void Start()
    {
        LoadScores();
        UpdateScoreboard();
        AddScore(MainManager.Instance.player.playerName, MainManager.Instance.player.playerScore);
    }

    public void AddScore(string name, int score)
    {
        scores.Add(new PlayerScore { name = name, score = score });
        scores.Sort((a, b) => b.score.CompareTo(a.score));
        if (scores.Count > maxScores)
        {
            scores.RemoveAt(maxScores);
        }
        SaveScores();
        UpdateScoreboard();
    }

    private void UpdateScoreboard()
    {
        scoreboardText.text = "High Scores:\n";
        foreach (PlayerScore score in scores)
        {
            scoreboardText.text += score.name + ": " + score.score + "\n";
        }
    }

    private void SaveScores()
    {
        string json = JsonUtility.ToJson(scores);
        PlayerPrefs.SetString("HighScores", json);
        PlayerPrefs.Save();
    }

    private void LoadScores()
    {
        if (PlayerPrefs.HasKey("HighScores"))
        {
            string json = PlayerPrefs.GetString("HighScores");
            scores = JsonUtility.FromJson<List<PlayerScore>>(json);
        }
    }
}
