using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    const float maxTimeToReturn = 5;
    float TimeToReturnToBounds;

    [SerializeField]
    HUDManager hud;

    [SerializeField]
    Submarine sub;

    bool isTimerStarted;

    private void Awake()
    {
        stopCountDownTimer();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Submarine>() != null)
        {
            stopCountDownTimer();
        }
    }

    private void OnTriggerExit(Collider other)
    {
         if(other.gameObject.GetComponent<Submarine>() != null)
        {
            startCountDownTimer();
        }
    }

    private void startCountDownTimer()
    {
        isTimerStarted = true;
    }

    private void stopCountDownTimer()
    {
        isTimerStarted = false;
        TimeToReturnToBounds = maxTimeToReturn;
        hud.HideTimer();
    }

    private void Update()
    {
        if (isTimerStarted)
        {
            hud.DisplayTimer(TimeToReturnToBounds);
            if((TimeToReturnToBounds -= Time.deltaTime) <= 0)
            {
                stopCountDownTimer();
                sub.resetLocation();  
            }
        }
    }
}
