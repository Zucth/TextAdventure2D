using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTraitAttachment", menuName = "Trait/Attachment", order = 1)]
public class TraitAttachment : ScriptableObject, ITrait
{
    [Range(-50, 50)]
    [Tooltip("plus or minus karma")]
    [SerializeField]
    private float karma;

    public float Karma
    {
        get { return karma; }
    }
}
