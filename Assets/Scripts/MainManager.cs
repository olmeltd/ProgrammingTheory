using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }
    public Player player;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            ResetPlayer();

            if (player.playerName == "Player0")
            {
                try
                {
                    LoadCurrentPlayer();
                    Debug.Log("Load last player");
                }
                catch (Exception)
                {
                    Debug.Log("Player not be Loaded or default");
                    SaveCurrentPlayer();
                }
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ResetPlayer()
    {
        player = new Player();
        player.playerName = "Player0";
        player.playerScore = 0;
        player.Inventory = new Inventory();
        player.Inventory.Items = new List<Item>();
       //player.Inventory.Items.Add(new Item() { iname = "MainKey", icount = 1 });
    }

    public void SaveCurrentPlayer() 
    {
        PlayerSerialize.SavePlayer(player, "Player.json");
    }

    public void LoadCurrentPlayer()
    {
        player = PlayerSerialize.LoadPlayer("Player.json");
    }





}
