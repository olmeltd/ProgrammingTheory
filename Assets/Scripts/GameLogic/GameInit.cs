using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    public TextMeshProUGUI item1;
    public TextMeshProUGUI item2;
    public TextMeshProUGUI item3;
    public TextMeshProUGUI item4;
    public TextMeshProUGUI item5;

    public TextMeshProUGUI itemDescription1;
    public TextMeshProUGUI itemDescription2;
    public TextMeshProUGUI itemDescription3;
    public TextMeshProUGUI itemDescription4;
    public TextMeshProUGUI itemDescription5;

    // Start is called before the first frame update
    void Start()
    {
        item1.text = "Пусто";
        itemDescription1.text = "---";
        item2.text = "Пусто";
        itemDescription2.text = "---";
        item3.text = "Пусто";
        itemDescription3.text = "---";
        item4.text = "Пусто";
        itemDescription4.text = "---";
        item5.text = "Пусто";
        itemDescription5.text = "---";

        if (MainManager.Instance != null)
        {
            MainManager.Instance.LoadCurrentPlayer();
            for(int i = 0; i < MainManager.Instance.player.Inventory.Items.Count; i++) 
            {
                GameObject keyObject = GameObject.Find(MainManager.Instance.player.Inventory.Items[i].iname);
                if (keyObject != null)
                {
                    keyObject.SetActive(false);
                }
                switch (i)
                {
                    case 0: 
                        item1.text = MainManager.Instance.player.Inventory.Items[i].iname;
                        itemDescription1.text = MainManager.Instance.player.Inventory.Items[i].iname; break;
                        case 1:
                        item2.text = MainManager.Instance.player.Inventory.Items[i].iname;
                        itemDescription2.text = MainManager.Instance.player.Inventory.Items[i].iname; break;
                        case 2:
                        item3.text = MainManager.Instance.player.Inventory.Items[i].iname;
                        itemDescription3.text = MainManager.Instance.player.Inventory.Items[i].iname; break;
                        case 3:
                        item4.text = MainManager.Instance.player.Inventory.Items[i].iname;
                        itemDescription4.text = MainManager.Instance.player.Inventory.Items[i].iname; break;
                        case 4:
                        item5.text = MainManager.Instance.player.Inventory.Items[i].iname;
                        itemDescription5.text = MainManager.Instance.player.Inventory.Items[i].iname; break;
                    default:
                        break;
                }
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
