using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class IamKey : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI Name;
    [SerializeField]
    TextMeshProUGUI NameItem;

    private string keyObjectName;
    
    public void Start()
    {
        keyObjectName = gameObject.name;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (MainManager.Instance != null)
        {
            if (!MainManager.Instance.player.Inventory.Items.Any(item => item.iname == keyObjectName))
            {
                // Add Name to inventory GUI
                Name.text = keyObjectName;
                // Check csore
                MainManager.Instance.player.playerScore += 10;
                Item keyitem = new Item();
                keyitem.iname = keyObjectName;
                keyitem.icount = 1;
                MainManager.Instance.player.Inventory.Items.Add(keyitem);
                NameItem.text = keyitem.iname;
                MainManager.Instance.SaveCurrentPlayer();
                gameObject.SetActive(false);
            }
        }
    }
}
