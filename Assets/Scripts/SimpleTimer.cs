using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SimpleTimer : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private TextMeshProUGUI timerText;

    private float _timeLeft = 0f;
    private bool _timerOn = false;

    private void Start()
    {

        _timeLeft = time;
        _timerOn = true;
    }

    private void Update()
    {
        if (_timerOn)
        {
            if (_timeLeft > 0)
            {
                _timeLeft -= Time.deltaTime;
                UpdateTimeText();
            }
            else
            {
                _timeLeft = time;
                _timerOn = false;
                if (MainManager.Instance != null)
                {
                    MainManager.Instance.gameOver = true;
                }
            }
        }
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
