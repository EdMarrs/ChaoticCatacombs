using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseStrength : MonoBehaviour
{

    /**** on triggering the collider (for 2D objects), passes a collider (for 2D objects) ****/
    private void OnTriggerEnter2D(Collider2D c)
    {

        /** if the collider's tag is "Player", find the player's attack value with the whipAttackScript and increment, destroy the object **/
        if (c.GetComponent<Collider2D>().tag == "Player")
        {

            GameObject.Find("Player").GetComponent<whipAttackScript>().damage = GameObject.Find("Player").GetComponent<whipAttackScript>().damage + 1;
            Destroy(gameObject);
        }
    }
}
