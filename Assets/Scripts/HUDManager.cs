using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{

    [SerializeField]
    Text outOfBoundsCountDownTimer;
    

    public void DisplayTimer(float timeRemaining)
    {
        outOfBoundsCountDownTimer.text = $"Warning, return to bounds in \n {timeRemaining}";
    }

    public void HideTimer()
    {
        outOfBoundsCountDownTimer.text = string.Empty;
    }
}
