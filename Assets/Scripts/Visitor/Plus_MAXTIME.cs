using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus_MAXTIME : MonoBehaviour, IElement
{
    public int time_upgrade = 110;
    public int max_time_upgrade = 350;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    private void Resent_UI()
    {
        //WholeTime.SetText(powerUp.current_MaxTime.ToString()); //bring HP_UI setText of the store_number of Overall HP that has been update ToString.
    }
}
