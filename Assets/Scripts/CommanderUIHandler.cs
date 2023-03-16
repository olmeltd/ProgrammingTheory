using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CommanderUIHandler : MonoBehaviour
{
    public TMP_InputField commander;
    // Start is called before the first frame update
    void Start()
    {

        if (MainManager.Instance != null)
        {
            if (MainManager.Instance != null)
            {
                commander.text = MainManager.Instance.player.playerName;
            }
            else
            {
                commander.text = "";
            }
        }
        else 
        {
            commander.text = "";
        }

    }

    public void StartGame()
    {
        if (commander.text == "Player0")
        {
            MainManager.Instance.ResetPlayer();
            LoadNextScene();
        }

        if (commander.text == MainManager.Instance.player.playerName)
        {
            LoadNextScene();
        }
        else
        {
            MainManager.Instance.ResetPlayer();
            MainManager.Instance.player.playerName = commander.text;
            MainManager.Instance.SaveCurrentPlayer();
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {

        // Выгрузить текущую сцену
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);


        // Загрузить следующую сцену
        SceneManager.LoadScene(4);
    }
}
