using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorController : MonoBehaviour, IElement 
{
    // Client was connect from Script: CoonectorManager2

    private List<IElement> _ielement = new List<IElement>();
    private void Start()
    {
        _ielement.Add(gameObject.AddComponent<Plus_HITPOINT>());
        _ielement.Add(gameObject.AddComponent<Plus_MAXSTAMINA>());
        _ielement.Add(gameObject.AddComponent<Plus_MAXTIME>());
    }

    public void Accept(IVisitor visitor)
    {
        foreach (IElement element in _ielement)
        {
            element.Accept(visitor);
        }
    }
}
