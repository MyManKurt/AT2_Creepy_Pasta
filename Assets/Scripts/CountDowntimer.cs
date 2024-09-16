using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//UI

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

    public float countDownTimer = 120;
    [SerializeField]
    public UnityEvent timerEnd = new UnityEvent();
    //Text

    private void Start()
    {
        countDownTimer = 120;
    }
    private void Update()
    {
        CountDown();
        //Display Timer
    }
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
