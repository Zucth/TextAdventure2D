using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

[CreateAssetMenu(fileName = "PowerUp", menuName ="PowerUp")]

public class PowerUp : ScriptableObject, IVisitor
{
    // ========== Starter Internal Values 
    [Range(0.0f, 5f)]
    [Tooltip("Upgrade 1 per unit, but can do up to plus 5")] 
    public float _MaxHP; //overall start EditorHP

    [Range(0.0f, 10f)]
    [Tooltip("Upgrade 2 per unit, but can do up to plus 10 ")]
    public float _MaxStamina; //stamina -1 when one action got used;

    [Range(0.0f, 45f)]
    [Tooltip("Upgrade 15 per unit, but can do up to plus 45 ")]
    public int _MaxTimeDuration; //stamina -1 when one action got used;
    // ===========

    public string PowerUp_name;
    public string Ability_Info;

    //public float current_hitPoint; //store +max hp
    //public float current_MaxStamina; //store +max stamina
    //public int current_MaxTime; //store +max time

    //add class Visitor(Classname classname) -> do what
    
    public void Visit(Plus_HITPOINT plus_HITPOINT)
    {
        plus_HITPOINT.current_hitPoint = plus_HITPOINT.hp_upgrade += _MaxHP;
        if (plus_HITPOINT.current_hitPoint >= plus_HITPOINT.max_hp_upgrade)
        {
            plus_HITPOINT.hp_upgrade = plus_HITPOINT.max_hp_upgrade;
        }
        else
            plus_HITPOINT.hp_upgrade = plus_HITPOINT.current_hitPoint;
        //Debug.Log(plus_HITPOINT.current_hitPoint);
    }
    public void Visit(Plus_MAXSTAMINA plus_MAXSTAMINA)
    {
        plus_MAXSTAMINA.current_MaxStamina = plus_MAXSTAMINA.stamina_upgrade += _MaxStamina;
        if (plus_MAXSTAMINA.current_MaxStamina >= plus_MAXSTAMINA.max_stamina_upgrade)
        {
            plus_MAXSTAMINA.stamina_upgrade = plus_MAXSTAMINA.max_stamina_upgrade;
        }
        else
            plus_MAXSTAMINA.stamina_upgrade = plus_MAXSTAMINA.current_MaxStamina;
        //Debug.Log(plus_MAXSTAMINA.current_MaxStamina);
    }
    
    public void Visit(Plus_MAXTIME plus_MAXTIME)
    {
        int current_MaxTime = plus_MAXTIME.time_upgrade += _MaxTimeDuration;
        if (current_MaxTime >= plus_MAXTIME.max_time_upgrade)
        {
            plus_MAXTIME.time_upgrade = plus_MAXTIME.max_time_upgrade;
        }
        else
            plus_MAXTIME.time_upgrade = current_MaxTime;
    }
    
}
