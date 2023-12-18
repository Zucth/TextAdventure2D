using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FacadeController : MonoBehaviour
{
    private AcceptCondition _acceptCondition;
    private DeclineCondition _declineCondition;

    public Animator publish_anim;
    public Animator decline_anim;

    public int R_num;

    public bool _IsLocked = false; //use to check if condition is locked of not <could be move this to EditorStatus Script>

    private void Awake()
    {
        //publish_anim = gameObject.GetComponent<Animator>();
        //decline_anim = gameObject.GetComponent<Animator>();
        _acceptCondition = gameObject.AddComponent<AcceptCondition>();
        _declineCondition = gameObject.AddComponent<DeclineCondition>();
    }

    private void Start()
    {
        _acceptCondition.facade = this;
        _declineCondition.facade = this;
    }

    //facade first func:
    //accept Condition and decline condition locked.
    //UI text -> red
    

    public void LockedBtn()  //I didn't use Ienumarator cause I don't have anything to keep rechecking or running out of time
    {
        _acceptCondition.DotheAnimation();
        _IsLocked = true;
    }

    //facade second func
    //accept and decline condition unlocked
    //UI text -> black

    public void UnlockedBtn()
    {
        _declineCondition.DothatProject();
        _IsLocked = false;
    }
}
