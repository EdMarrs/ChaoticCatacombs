using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;        // sets 1-way platform collisions


    /**** on the loaded scene, set the effector to get the platform effector ****/
    void Start()
    {

        effector = GetComponent<PlatformEffector2D>();      // sets equal to current effector attached to platform
    }
    /**** updates every frame ****/
    void Update()
    {

        /** if the input is down arrow or the vertical axis is less than 0, set the rotational offset to 180 **/
        // Player will fall through platform when down arrow key is pressed
        // They will continue to fall through platforms if they hold the key
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Vertical")<0)
        {
        
            effector.rotationalOffset = 180f;
        }
        /** if the input is down arrow or the vertical axis is greater than or equal to 0, set the rotational offset to 0 **/
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetAxis("Vertical") >= 0)
        {

             effector.rotationalOffset = 0;
        }

    }
}
