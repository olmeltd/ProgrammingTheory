using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class IamKey : MonoBehaviour
{

    private string keyObjectName;
    public ScoreManager scoreManager;
    private string emptystring;
    private bool ihavekey = false;

    public void Start()
    {
        keyObjectName = gameObject.name;
        scoreManager = FindObjectOfType<ScoreManager>();
        emptystring = "---";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (MainManager.Instance != null)
        {


            for (int i = 0; i < 5; i++)
            {


                TextMeshProUGUI textField = GameObject.FindObjectsOfType<TextMeshProUGUI>().Where(
                    obj => obj.name == "NameItem" + (1 + i).ToString()).FirstOrDefault();

                if (!ihavekey)
                {

                    if (textField.text == emptystring )
                    {

                        // Add Name to inventory GUI
                        //Name.text = keyObjectName;
                        // Check csore
                        MainManager.Instance.player.playerScore += 10;
                        scoreManager.AddScore(MainManager.Instance.player.playerName, MainManager.Instance.player.playerScore);

                        // add item
                        Item keyitem = new Item();
                        keyitem.iname = keyObjectName;
                        keyitem.icount = 1;
                        MainManager.Instance.player.Inventory.Items.Add(keyitem);
                        //NameItem.text = keyitem.iname;
                        MainManager.Instance.SaveCurrentPlayer();
                        textField.SetText(MainManager.Instance.player.Inventory.Items[i].iname);
                        gameObject.SetActive(false);
                        ihavekey = true;
                    }
                }
            }


            //if (!MainManager.Instance.player.Inventory.Items.Any(item => item.iname == keyObjectName))
            //{
            //    if (MainManager.Instance.player.Inventory.Items.Count < 6)
            //    {
            //        // Add Name to inventory GUI
            //        Name.text = keyObjectName;
            //        // Check csore
            //        MainManager.Instance.player.playerScore += 10;
            //        scoreManager.AddScore(MainManager.Instance.player.playerName, MainManager.Instance.player.playerScore);

            //        // add item
            //        Item keyitem = new Item();
            //        keyitem.iname = keyObjectName;
            //        keyitem.icount = 1;
            //        MainManager.Instance.player.Inventory.Items.Add(keyitem);
            //        NameItem.text = keyitem.iname;
            //        MainManager.Instance.SaveCurrentPlayer();
            //        gameObject.SetActive(false);
            //    }
            //}
        }
    }
}
