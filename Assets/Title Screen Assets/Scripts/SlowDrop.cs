using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDrop : MonoBehaviour
{
    float speed;
    Vector3 direction;
    float min;
    float max;
    float units = 670.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Set max to current position on Y axis, and set min to current minus units
        max = transform.position.y;
        min = transform.position.y - units;

        //Set Moving Direction to Down
        direction = Vector3.down;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == Vector3.down)
        {
            speed = 90f;
        }

        //Use transform.Translate to move the current direction and current speed
        transform.Translate(direction * speed * Time.deltaTime);

        //Change direction if object has reached min or max position on the Y axis (up or down)
        if (transform.position.y >= max)
        {
            direction = Vector3.down;
        }

        if (transform.position.y <= min)
        {
            direction = Vector3.zero;
        }
    }
}