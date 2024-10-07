using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#region AUTHOR & COPYRIGHT DETAILS

/// Original Author: Kurtis Jackson
/// Contact: Kurtis Jackson <Kurtcprive@gmail.com>.
/// Contributing Authors: 
/// Last Updated: October, 2024
/// 
/// ###---**COPYRIGHT STATEMENT**---###
/// © Copyright 2024 South Metropolitan TAFE. All rights reserved.
/// This code is provided by student of South Metropolitan TAFE for educational purposes only.
/// Unauthorized use, including but not limited to sharing, redistributing, copying, or commercialising
/// this code or any part of it, without the express written permission of the authors, is strictly prohibited.
/// </remarks>
#endregion


public class CountDowntimer : MonoBehaviour
{
    /*
    Timer starts count down at the start of the game
    Player must find win location before timer hits 0
    Else player loses game

    //bool - True/False
    //string - +{Pk093?!@"'
    //float - 0.0
    //int - whole number 10 -52 1067
     */
    //Countdown timer - float

    //Countdown timer starts at 215 seconds and counts down to 0
    //on timer end trigger game LoseState
    public float countDownTimer = 215;
    [SerializeField]
    public UnityEvent timerEnd = new UnityEvent();
    public Text timerDisplay;

    /// <summary>
    /// sets timer to 215 seconds
    /// </summary>
    private void Start()
    {
        countDownTimer = 215;
        timerDisplay = GameObject.FindGameObjectWithTag("CountDown").GetComponent<Text>();
    }
    /// <summary>
    /// sets how the timer format should display on screen to the player
    /// </summary>
    private void Update()
    {
        CountDown();
        timerDisplay.text = string.Format("{0:0.00}", countDownTimer);
    }
    /// <summary>
    /// if timer hits 0 the game ends
    /// </summary>
    void CountDown()
    {
        if (countDownTimer > 0)
        {
            countDownTimer -= Time.deltaTime;
            if (countDownTimer <= 0)
            {
                countDownTimer = 0;
                timerEnd.Invoke();
            }
        }
       
    }
}
