using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMiniMap : MonoBehaviour
{
    private bool isOn = true;
    
  
    void Update()
    {
 
        // turns off camera
        if ((Input.GetKeyDown("1") || Input.GetKeyDown("joystick button 3"))&& isOn == true)
        {

            this.GetComponent<RawImage>().enabled = false;
            isOn = false;
        }
        
        // turns off camera
        else if ((Input.GetKeyDown("1") || Input.GetKeyDown("joystick button 3")) && isOn == false)
        {

            this.GetComponent<RawImage>().enabled = true;
            isOn = true;
        }
        

    }
}

