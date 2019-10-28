using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;

    void Start()
    {
        // sets equal to current effector attached to platform
        effector = GetComponent<PlatformEffector2D>();

       
       
        

    }

    void Update()
    {
           


         // Player will fall through platform when down arrow key is pressed
        // They will continue to fall through platforms if they hold the key
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
        
            effector.rotationalOffset = 180f;
          
        }


        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
             effector.rotationalOffset = 0;
            
        }

    }
}
