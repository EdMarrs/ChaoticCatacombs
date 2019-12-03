using System;
using UnityEngine;

public class fadingInHa : MonoBehaviour
{
    float appearDelay;
    float delay;
    float timer;
    bool show;
    float speed;
    Vector3 initialPos;


    // Start is called before the first frame update
    void Start()
    {

        timer = 0f;
        delay = .00755f;        // delay between actions called in Update, Start delay of the object, will not let other sections of code run before this delay passes
        appearDelay = 1f;       // Allows the update function to run movement code
        show = false;
        speed = .25f;
        initialPos = transform.position;        //Maintains the initial position of the words
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;            // sets timer to increment by time

        /** if the timer is greater than the appear delay, set timer to 0 and set show to true **/
        if (timer > appearDelay)
        {
        	timer = 0f;
        	show = true;
        }
        /** if show, then check if the timer is greater than the delay **/
        if (show)
        {

            /** if the timer is greater than the delay, set the timer to 0 and check the Z-axis rotation **/
        	if (timer > delay)
        	{

        		timer = 0f;         // set timer to 0

                /** if the rotation on the Z-axis is greater than 0, check the position on the X-axis 
                 * else if, set the position on the Y-axis to be positive
                **/
        		//Determines if the object needs angular or straight movement
        		if (Math.Abs(transform.rotation.z) > 0)
        		{

                    /** if the position on the X-axis is less than 0, set the new position negatively in the X-axis
                     * else if, set the new position positively in the X-axis
                    **/
        			if (transform.position.x < 0)
        			{

                        // set the position to X-axis - speed * Time, Y-axis + speed * Time, 0
        				transform.position = new Vector3(transform.position.x - speed * Time.deltaTime,
        					transform.position.y + speed * Time.deltaTime, 0);
        			}
        			else
        			{

                        // set the position to X-axis + speed * Time, Y-axis + speed * Time, 0
        				transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
        					transform.position.y + speed * Time.deltaTime, 0);
        			}
        		}
        		else
        		{

                    // set the position to X-axis, Y-axis + speed * Time, 0
        			transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, 0);
        		}
        	}

        	transform.position = initialPos;        	// Sets the object back to the initial position between delays
        }
    }
}
