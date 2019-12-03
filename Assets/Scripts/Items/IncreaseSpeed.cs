using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{

    /**** on triggering the collider (for 2D objects), passes a collider (for 2D objects) ****/
    private void OnTriggerEnter2D(Collider2D c)
    {

        /** if the collider's tag is "Player", find the player's speed with the PlayerController and increment, destroy the object **/
        if (c.GetComponent<Collider2D>().tag == "Player")
        {

            GameObject.Find("Player").GetComponent<PlayerController>().speed = GameObject.Find("Player").GetComponent<PlayerController>().speed + 5;
            Destroy(gameObject);
        }
    }
}
