using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    public GameObject playerLocation;
    public bool standing;

    void Start()
    {
        // sets equal to current effector attached to platform
   //    effector = GetComponent<PlatformEffector2D>();

       
       
        

    }

    // delay so the player doesn't just fall though platform when they press down
    // and they dont continue falling though other platforms below
    IEnumerator A()
    {
       
        standing = true;
        yield return new WaitForSecondsRealtime(0.15f);
        standing = false;

    }


    void Update()
    {

        // if the player is above the platform and not holding down, then they can stand on the platform
        if (playerLocation.transform.position.y > gameObject.transform.position.y && !Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.layer = 8;
        }
        
        if(standing == true)
        {
            gameObject.layer = 18;
        }

        // if the player is above the platform and are holding down, then they will wait about a tenth of a second then fall through
        else if (playerLocation.transform.position.y > gameObject.transform.position.y && Input.GetKeyDown(KeyCode.DownArrow))
        {
            StopCoroutine(A());
            StartCoroutine(A());
        }

        // if the player is below the platform then they can jump from underneath
        else if (playerLocation.transform.position.y < gameObject.transform.position.y)
        {
            gameObject.layer = 18;      
        }

        // otherwise the platform should be solid
        else
        {
            gameObject.layer = 8;
        }


        /*
        // Player will fall through platform when down arrow key is pressed
        // They will continue to fall through platforms if they hold the key
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Vertical")<0)
        {
        
            effector.rotationalOffset = 180f;
          
        }


        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetAxis("Vertical") >= 0)
        {
             effector.rotationalOffset = 0;
            
        }
        */

    }
}
