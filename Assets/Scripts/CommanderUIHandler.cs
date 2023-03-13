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
                MainManager.Instance.LoadPlayer();
                commander.text = MainManager.Instance.playerName;
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
        MainManager.Instance.playerName = commander.text;
        MainManager.Instance.SavePlayer();
        SceneManager.LoadScene(4);
    }
}
