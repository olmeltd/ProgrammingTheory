using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActiveScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.SetActiveScene(gameObject.scene); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
