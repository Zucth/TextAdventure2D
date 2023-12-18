using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus_HITPOINT : MonoBehaviour, IElement
{
    public float hp_upgrade = 3;
    public float max_hp_upgrade = 20;

    public float current_hitPoint;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
