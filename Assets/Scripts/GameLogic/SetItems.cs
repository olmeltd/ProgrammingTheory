using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetItems : MonoBehaviour
{
    GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        // Найти первый объект с тегом "Player"
        gameManager = GameObject.FindWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
