using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;



public class PlayerSerialize : MonoBehaviour
{
    public static void SavePlayer(Player player, string fileName)
    {
        string json = JsonUtility.ToJson(player);
        Debug.Log("Save data: " + json);
        File.WriteAllText(Application.persistentDataPath + "/" + fileName, json);
    }

    public static Player LoadPlayer(string fileName)
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/" + fileName);
        Player player = JsonUtility.FromJson<Player>(json);
        Debug.Log("Load data: " + json);
        return player;
    }
}
