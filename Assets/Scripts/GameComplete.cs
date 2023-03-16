using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{

    public ScoreManager scoreManager;
    public string nextSceneName = "GameComplete";

    public void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (MainManager.Instance != null)
        {
            MainManager.Instance.gameOver = false;
            scoreManager.AddScore(MainManager.Instance.player.playerName, MainManager.Instance.player.playerScore);
            LoadNextScene();
        }
        else 
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {

        // ��������� ������� �����
       // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        // ��������� ��������� �����
        SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
    }
}
