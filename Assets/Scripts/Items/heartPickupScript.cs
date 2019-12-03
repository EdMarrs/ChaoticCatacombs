using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartPickupScript : MonoBehaviour
{
    /**** on collider triggered (for 2D objects), passes collider (for 2D objects) ****/
    private void OnTriggerEnter2D(Collider2D c)
    {

        /** if collider's tag is "Player", check the health and # of hearts, destroy the game object **/
        if (c.GetComponent<Collider2D>().tag == "Player")
        {

            /** if the game object's collider's # of hearts is less than 5, find and set the # of hearts to be incremented **/
            if (GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().numberOfHearts < 5)

            {
                GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().numberOfHearts = GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().numberOfHearts + 1;
            }
            /** if the game object's collider's health is less than 5, find and set the health to be incremented **/
            if (GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().health < 5)
            {

                GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().health = GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().health + 1;
            }

            Destroy(gameObject);
        }
    }
}
