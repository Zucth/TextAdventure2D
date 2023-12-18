using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptCondition : MonoBehaviour
{
    public FacadeController facade;

    public void DotheAnimation()
    {
        facade.publish_anim.SetBool("_IsLocked", true);
        facade.decline_anim.SetBool("_IsLocked", true);
    }
}
