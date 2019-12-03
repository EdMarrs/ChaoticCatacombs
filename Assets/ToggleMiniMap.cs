using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMiniMap : MonoBehaviour
{
    private bool isOn = true;
  
    void Update()
    {
 
        // gives the effect of the mini map being toggled off
        if (Input.GetKeyDown("1") && isOn == true)
        {  
            
            transform.localScale = new Vector3(0, 0, 0);
            isOn = false;
        }

        // gives the effect of the mini map being toggled on
        else if (Input.GetKeyDown("1") && isOn == false)
        {
            
            transform.localScale = new Vector3(1, 1, 0);
            isOn = true;
        }
        

    }
}

