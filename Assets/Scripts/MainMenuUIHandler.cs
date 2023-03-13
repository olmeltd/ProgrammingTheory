using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MainMenuUIHandler : MonoBehaviour
{
    public void StartNewGame()
    {
        SceneManager.LoadScene(3);
    }

    public void OptionsSceneLoad()
    {
        SceneManager.LoadScene(2);
    }

    public void ScoreboardSceneLoad()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit(); // original code to quit Unity player
    #endif
    }
}
