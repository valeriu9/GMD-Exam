using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_ : MonoBehaviour
{
    public float TimeValue;
    public Text TimerText;
    private bool IsZero = true;
     void Start()
    {
       // stopAnimation();
        switch (PlayerPrefs.GetInt("Level"))
        {
            case 0:
                TimeValue = 360;
                break;
            case 1:
                TimeValue = 300;
                break;
            case 2:
                TimeValue = 240;
                break;
            case 3:
                TimeValue = 180;
                break;
            case 4:
                TimeValue = 120;
                break;
            case 5:
                TimeValue = 90;
                break;
            default:
                TimeValue = 90;
                break;
        }
    }

    void Update()
    {
        if (TimeValue > 0)
        {
            TimeValue -= Time.deltaTime;
        }
        else
        {
            TimeValue = 0;
            if (IsZero)
            {
                print("reached here");
                stopAnimation();
            }
            IsZero = false;
        }
        if(TimeValue < 10 && IsZero)
        {
            triggerAnimation();
        }
        DisplayTime(TimeValue);
    }
        void DisplayTime(float timeToDisplay)
        {
            if (timeToDisplay < 0)
            {
                timeToDisplay = 0;
            }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    void triggerAnimation()
    {
        GetComponent<Animator>().enabled = true;

    }
    void stopAnimation()
    {
        GetComponent<Animator>().enabled = false;
    }
}
