using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EditorStatus : MonoBehaviour
{
    //public StatusConfig statusConfig;
    //public MainAttachment mainAttachment;

    // ========== Class connect
    private PowerUp powerUp;
    private TimerCount _timerCount;
    //private AcceptCondition _acceptCondition;
    //private DeclineCondition _declineCondition;

    // ========== visual Values compare
    

    public TMP_Text Day;
    public TMP_Text Stamina;
    public TMP_Text HitPoint;
    public TMP_Text WholeTime;

    // ===========
    private bool OutofTime; //always set as true when start a new day. being called when start a new day together with time to reset.
    private bool TimerIsRunning; //set as false after TimeRemain <= 0.

    public void FirstDay()
    {

    }

    public void NextDay()
    {
        //connect to UI Facade -> to update the int UI
        //connect to play sound chicken
    }

    public void ResetTheDay()
    {

        //powerUp.TimeRemain = powerUp.current_MaxTime;
    }

}
