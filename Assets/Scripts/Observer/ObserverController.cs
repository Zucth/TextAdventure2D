using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObserverController : Subject
{
    private HUDController hUDController;
    private CoonectorManager2 coonectorManager2;

    public float DayValues;

    public TMP_Text Day;
    public TMP_Text Stamina;
    public TMP_Text HitPoint;
    //public TMP_Text WholeTime;

    public bool sentMe  { get; private set; }

private void Awake()
    {
        //hUDController = (HUDController)FindObjectOfType(typeof(HUDController));
        hUDController = gameObject.AddComponent<HUDController>();
        coonectorManager2 = gameObject.GetComponent<CoonectorManager2>();
        //Debug.Log(coonectorManager2);
    }

    private void OnEnable()
    {
        if (hUDController)
        {
            Attach(hUDController);
        }
    }

    private void OnDisable()
    {
        if (hUDController)
        {
            Detach(hUDController);
        }
    }

    public void SetUI()
    {
        float sta = coonectorManager2.current_max_STA + coonectorManager2.extra_stamina;

        sentMe = true;
        //Debug.Log("coonectorManager2.current_HP: " + coonectorManager2.current_HP);
        HitPoint.text = "HitPoint: " + coonectorManager2.current_HP.ToString();
        Stamina.text = "Stamina: " + sta.ToString();
        DayValues++;
        NotifyObserver();
    }
}
