using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int maxScoresToShow = 10;

    private List<ScoreEntry> scoreList = new List<ScoreEntry>();

    private string SCORES_FILE_PATH; 

    private void Start()
    {
        SCORES_FILE_PATH = Application.persistentDataPath + "/" + "scores.json";
        LoadScores();
    }

    public List<ScoreEntry> GetTopScores()
    {
        return scoreList.GetRange(0, Mathf.Min(maxScoresToShow, scoreList.Count));
    }

    private void LoadScores()
    {
        if (File.Exists(SCORES_FILE_PATH))
        {
            string json = File.ReadAllText(SCORES_FILE_PATH);
            scoreList = JsonUtility.FromJson<ScoreList>(json).scores;
            SortScores();
        }
        else 
        {
            AddScore(MainManager.Instance.player.playerName, MainManager.Instance.player.playerScore);
            SaveScores();
        }
    }

    private void SaveScores()
    {
        ScoreList scoreListToSave = new ScoreList { scores = scoreList };
        string json = JsonUtility.ToJson(scoreListToSave);
        File.WriteAllText(SCORES_FILE_PATH, json);
    }

    public void AddScore(string name, int score)
    {
        ScoreEntry existingEntry = scoreList.Find(entry => entry.name == name);
        if (existingEntry != null)
        {
            existingEntry.score = score;
            SortScores();
        }
        else
        {
            ScoreEntry newEntry = new ScoreEntry { name = name, score = score };
            scoreList.Add(newEntry);
            SortScores();
            if (scoreList.Count > maxScoresToShow)
            {
                scoreList.RemoveAt(maxScoresToShow);
            }
        }
        SaveScores();
    }

    private void SortScores()
    {
        scoreList.Sort((entry1, entry2) => entry2.score.CompareTo(entry1.score));
    }

    [System.Serializable]
    public class ScoreEntry
    {
        public string name;
        public int score;
    }

    [System.Serializable]
    private class ScoreList
    {
        public List<ScoreEntry> scores;
    }

   
}