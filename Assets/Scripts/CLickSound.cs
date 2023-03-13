using System;
using System.Collections.Generic;
using ElRaccoone.Tweens;
using ElRaccoone.Tweens.Core;
using Interface.Elements.Scripts;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CLickSound : MonoBehaviour
{
    public AudioClip onClickAudio;

    public void MyClick()
    {
        if (onClickAudio != null) 
        {
            AudioManager.Play(onClickAudio);
        }
    }
    
}
