using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;
using System;

[Serializable]
public class Player
{
    public string playerName;
    public int playerScore;
    public Inventory Inventory;
}
