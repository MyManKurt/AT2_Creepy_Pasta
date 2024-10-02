using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


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

    public float countDownTimer = 215;
    [SerializeField]
    public UnityEvent timerEnd = new UnityEvent();
    public Text timerDisplay;

    private void Start()
    {
        countDownTimer = 215;
        timerDisplay = GameObject.FindGameObjectWithTag("CountDown").GetComponent<Text>();
    }
    private void Update()
    {
        CountDown();
        timerDisplay.text = string.Format("{0:0.00}", countDownTimer);
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
