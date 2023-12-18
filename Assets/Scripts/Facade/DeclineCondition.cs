using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclineCondition : MonoBehaviour
{
    public FacadeController facade;

    public void DothatProject()
    {
        //Debug.Log("Hello");
        facade.publish_anim.SetBool("_IsLocked", false);
        facade.decline_anim.SetBool("_IsLocked", false);
    }
}
