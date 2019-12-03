using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{

    public AudioMixer mixer;        // sets mixer for the audio
    public Slider slider;           // sets slider


    /**** on scene load, set the value of the slider to be the Player's Preference ****/
    void Start()
    {

        slider.value = PlayerPrefs.GetFloat("MusicVol", 0.75f);         // set the value to be modified by 0.75
    }
    /**** set the level of the volume ****/
    public void SetLevel()
    {

        float sliderValue = slider.value;                               // sets the slider value
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);      // the mixer sets the volume by log(slider value) * 20
        PlayerPrefs.SetFloat("MusicVol", sliderValue);                  // sets Player's Preference to the slider value
    }
}