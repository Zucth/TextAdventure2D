using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public CoonectorManager2 gameManager;

    [SerializeField] private TMP_Text Stamina;
    [SerializeField] private TMP_Text HitPoint;

    public void SetHealthUI()
    {
        HitPoint.text = "HitPoint: " + gameManager.current_HP.ToString();
    }
    public void SetStaminaUI()
    {
        Stamina.text = "Stamina: " + gameManager.current_STA.ToString();
    }
}
