using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SetHardMode : MonoBehaviour
{
    Toggle toggleValue;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("HardModeToggle").GetComponent<Toggle>().isOn = toggleValue;
        
    }


    void Update()
    {
        //GameObject.Find("HardModeToggle").GetComponent<Toggle>().isOn = toggleValue;

        if (toggleValue == true)
        {
            PlayerPrefs.SetInt("HardModeOn", 1);
            Debug.Log("Toggle is set to true");
        }
        else
        {
            PlayerPrefs.SetInt("HardModeOn", 0);
            Debug.Log("Toggle is set to false");
        }
    }
}
