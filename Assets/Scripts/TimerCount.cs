using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCount : MonoBehaviour
{
    //these are not used.
    public float timeRemaining = 10;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
    }
}
