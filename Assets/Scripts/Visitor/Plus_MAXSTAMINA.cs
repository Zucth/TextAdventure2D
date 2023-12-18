using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus_MAXSTAMINA : MonoBehaviour, IElement
{
    public float stamina_upgrade = 5;
    public float max_stamina_upgrade = 35;

    public float current_MaxStamina;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
