using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverEvent : MonoBehaviour
{
    public string nextSceneName = "GameOver";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (MainManager.Instance != null)
        {
            if (MainManager.Instance.gameOver)
            {
                MainManager.Instance.gameOver = false;
                LoadNextScene();
            }
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
