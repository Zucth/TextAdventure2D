using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorController : MonoBehaviour
{
    public TraitConfig traitConfig;
    public TraitAttachment traitAttachment; //only one attach due to event

    private CoonectorManager2 coonector;

    private ITrait _ITrait;
    private bool _isDecorated;

    private void Awake()
    {
        _ITrait = new Trait(traitConfig); //auto assign trait config? or is this just make it the code capture the input value?
        coonector = GetComponent<CoonectorManager2>();
    }
    public void Reset()
    {
        _ITrait = new Trait(traitConfig);
        _isDecorated = !_isDecorated;

        //_ITrait.Karma // this is karma present value.
    }

    public void CheckAttachmentValue()
    {
        if (traitAttachment && _isDecorated)
        {
            Debug.Log("Main Attachment: " + traitAttachment.name);
        }
    }

    public void CheckForKarma()
    {
        if(_ITrait.Karma >= 25)
        {
            coonector.extra_stamina = 3;
            Debug.Log("Your karma is quite good, not many people has negative thought toward you recently.");
        }
        else if (_ITrait.Karma <= -25)
        {
            coonector.extra_stamina = -3;
            Debug.Log("Your karma is terrible, your news has create chaos over the town people feel resentment toward you.");
        }
    }

    public void Decorate()
    {
        if (traitAttachment)
        {
            _ITrait = new TraitDecorator(_ITrait, traitAttachment);
        }
        _isDecorated = !_isDecorated;
    }
}
