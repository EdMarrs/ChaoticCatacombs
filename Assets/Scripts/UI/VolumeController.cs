using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

/*** Controls the volume settings ***/
public class VolumeController : MonoBehaviour
{
    public AudioMixer mixer;            // Audio mixer
    public Slider slider;               // slider

    /*** Passes some value to the slider ***/
    public void setLevel()
    {
        float sliderValue = slider.value;

        mixer.SetFloat("Volume", Mathf.Log10(sliderValue) * 20);
    }
}