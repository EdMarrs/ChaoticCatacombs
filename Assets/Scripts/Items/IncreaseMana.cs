using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMana : MonoBehaviour
{

    /**** on triggering the collider (for 2D objects), passes a collider (for 2D objects) ****/
    private void OnTriggerEnter2D(Collider2D c)
    {

        /** if the collider's tag is "Player", find the player's max and current bar with the advSpecial and increment, destroy the object **/
        if (c.GetComponent<Collider2D>().tag == "Player")
        {

            GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarMax = GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarMax + 50;
            GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarCurr = GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarMax;
            Destroy(gameObject);
        }
    }
}
