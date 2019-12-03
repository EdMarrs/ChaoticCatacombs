using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    public GameObject playerLocation;
    public bool standing;
    private bool alreadyHoldingDown;

    void Start()
    {
        // sets equal to current effector attached to platform
        //    effector = GetComponent<PlatformEffector2D>();

    alreadyHoldingDown=false;



}

    // delay so the player doesn't just fall though platform when they press down
    // and they dont continue falling though other platforms below
    IEnumerator A()
    {
       
        standing = true;
        yield return new WaitForSecondsRealtime(0.15f);
        standing = false;

    }

    IEnumerator A2()
    {

        standing = true;
        yield return new WaitForSecondsRealtime(0.2f);
        standing = false;

    }


    void Update()
    {

        // if the player is above the platform and not holding down, then they can stand on the platform
        if (playerLocation.transform.position.y > gameObject.transform.position.y && (!Input.GetKey(KeyCode.DownArrow)))
        {
            gameObject.layer = 8;
        }
        if(playerLocation.transform.position.y > gameObject.transform.position.y && Input.GetAxis("Vertical") >= 0)
        {
            gameObject.layer = 8;
        }

        if (standing == true)
        {
            gameObject.layer = 18;
        }
        if (playerLocation.transform.position.y < gameObject.transform.position.y)
        {
            gameObject.layer = 18;
        }

        // if the player is above the platform and are holding down, then they will wait about a tenth of a second then fall through
        if (playerLocation.transform.position.y > gameObject.transform.position.y && (Input.GetKeyDown(KeyCode.DownArrow)))
        {
            
            StopCoroutine(A());
            StartCoroutine(A());
                
        }
        

        else if (playerLocation.transform.position.y > gameObject.transform.position.y &&  Input.GetAxis("Vertical") < 0)
        {
            if (!alreadyHoldingDown)
            {
                StopCoroutine(A2());
                StartCoroutine(A2());
                Debug.Log("Yeet1");
            }
            alreadyHoldingDown = true;
            Debug.Log("Yeet2");
        }

        else if(Input.GetAxisRaw("Vertical") >= 0)
        {
            alreadyHoldingDown = false;
            
        }

        // if the player is below the platform then they can jump from underneath
       

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
