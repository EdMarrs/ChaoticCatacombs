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
        //delay between actions called in Update
        delay = .00755f;
        //Start delay of the object, will not let other
        //sections of code run before this delay passes
        appearDelay = 1f;
        //Allows the update function to run movement code
        show = false;
        speed = .25f;
        //Maintains the initial position of the words
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > appearDelay)
        {
        	timer = 0f;
        	show = true;
        }
        if (show)
        {
        	if (timer > delay)
        	{
        		timer = 0f;
        		//Determines if the object needs angular or straight movement
        		if (Math.Abs(transform.rotation.z) > 0)
        		{
        			if (transform.position.x < 0)
        			{
        				transform.position = new Vector3(transform.position.x - speed * Time.deltaTime,
        					transform.position.y + speed * Time.deltaTime, 0);
        			}
        			else
        			{
        				transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
        					transform.position.y + speed * Time.deltaTime, 0);
        			}
        		}
        		else
        		{
        			transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, 0);
        		}
        	}
        	//Sets the object back to the initial position between delays
        	transform.position = initialPos;
        }
    }
}
