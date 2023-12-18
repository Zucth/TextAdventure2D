using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

[RequireComponent(typeof(Slider))]
public class SliderForSoundOPtion : MonoBehaviour
{   Slider slider
    {
        get { return GetComponent<Slider>(); }
    }
    public AudioMixer mixer;
    public string VolumeName;

    public void UpdateValuesOnChange(float value)
    {
        mixer.SetFloat(VolumeName, Mathf.Log10(value)*20);
    }
}
