using System;
using UnityEngine;

public class gameOverMovement : MonoBehaviour
{
    float speed;
    float timer;
    float delay;
    float appearDelay;
    bool start;

    // Start is called before the first frame update
    void Start()
    {
        start = true;
        delay = .01755f;
        appearDelay = 3f;
        timer = 0f;
        speed = .005f;
    }

    // Update is called once per frame
    void Update()
    {
    	timer += Time.deltaTime;
    	if (start)
    	{
    		if (timer < appearDelay)
    		{
    			transform.position = new Vector3(transform.position.x, transform.position.y - speed, 0);
    		}
    		else
    		{
    			timer = 0f;
    			start = false;
    			speed = .15f;
    		}
    	}
    	else
    	{
    		if (timer > delay)
    		{
    			timer = 0f;
                if (transform.position.y < .19)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, 0);
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y - speed * delay, 0);
                    }
                }
    		}
    	}
    }
}
