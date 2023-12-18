using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTraitConfig", menuName = "Trait/Config", order = 1)]
public class TraitConfig : ScriptableObject, ITrait
{
    [Range(-50, 50)]
    [Tooltip("Amount of Karma = 0")]
    [SerializeField]
    private float karma;

    public string TraitName;
    //public GameObject Trait_Prefabs; //its a text game, there is no prefabs
    public string Trait_Description;

    public float Karma
    {
        get { return karma; }
    }
}
