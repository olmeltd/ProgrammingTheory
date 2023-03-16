using Interface.Elements.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopmenuSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (AudioManager._i != null)
        {
            AudioManager.OnOffAudio();
        }
        else 
        {
            Debug.Log("Global audio source not present");
        }
    }
}
