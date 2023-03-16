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

        // Выгрузить текущую сцену
       // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        // Загрузить следующую сцену
        SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
    }
}
