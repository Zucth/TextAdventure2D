using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDController : Observer
{
    private ObserverController observerController;

    private float DayValues;

    private TMP_Text Day;
    private TMP_Text Stamina;
    private TMP_Text HitPoint;
    //private TMP_Text WholeTime;

    private bool sentMe;

    public void Update()
    {
        CheckUpdate();
    }

    public void CheckUpdate()
    {
        if (sentMe == true)
        {
            sentMe = false;
            StartCoroutine(SetUpUI(1));
        }
        if (sentMe == false)
        {
            //do nothing
        }
    }

    IEnumerator SetUpUI(float waitforSecs)
    {
        yield return new WaitForSeconds(waitforSecs);
        Day.text = "Day: " + DayValues.ToString();
    }

    public override void Notify(Subject subject)
    {
        if (!observerController)
        {
            observerController = subject.GetComponent<ObserverController>();
        }
        if (observerController)
        {
            DayValues = observerController.DayValues;

            Day = observerController.Day;
            Stamina = observerController.Stamina;
            HitPoint = observerController.HitPoint;
            //WholeTime = observerController.WholeTime;

            sentMe = observerController.sentMe;
        }
    }
}
