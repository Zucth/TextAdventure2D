using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trait : ITrait
{
    public float Karma
    {
        get { return _config.Karma; }
    }

    private readonly TraitConfig _config;

    public Trait(TraitConfig traitConfig)
    {
        _config = traitConfig;
    }
}
