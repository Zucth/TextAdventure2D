using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraitDecorator : ITrait
{
    private readonly ITrait _decorateTrait;
    private readonly TraitAttachment _attachment;

    public TraitDecorator(ITrait trait, TraitAttachment attachment)
    {
        _decorateTrait = trait;
        _attachment = attachment;
    }

    public float Karma
    {
        get { return _decorateTrait.Karma + _attachment.Karma; }
    }
}
