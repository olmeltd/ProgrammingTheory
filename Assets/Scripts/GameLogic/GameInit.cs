using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        if (MainManager.Instance != null)
        {

            MainManager.Instance.LoadCurrentPlayer();
            for (int i = 0; i < MainManager.Instance.player.Inventory.Items.Count; i++)
            {

                TextMeshProUGUI textField = GameObject.FindObjectsOfType<TextMeshProUGUI>().Where(
                    obj => obj.name == "NameItem"+(1+i).ToString()).FirstOrDefault();
                if (textField != null)
                {
                    textField.SetText(MainManager.Instance.player.Inventory.Items[i].iname);
                    GameObject gameObjectKey = GameObject.FindObjectsOfType<GameObject>().Where(
                    obj => obj.name == MainManager.Instance.player.Inventory.Items[i].iname).FirstOrDefault();
                    gameObjectKey.SetActive(false);
                }
                else
                {
                    Debug.LogWarning("Не удалось найти поле текста с именем ");
                }
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
