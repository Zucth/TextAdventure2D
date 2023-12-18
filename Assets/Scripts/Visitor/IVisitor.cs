using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVisitor
{
    //void Visit(ClassName className);
    void Visit(Plus_HITPOINT plus_HITPOINT);
    void Visit(Plus_MAXSTAMINA plus_MAXSTAMINA);
    void Visit(Plus_MAXTIME plus_MAXTIME);
}
