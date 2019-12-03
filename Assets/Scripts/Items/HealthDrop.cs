using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{
    public int chanceToSpawnHealth = 10;        // sets the chance to spawn health
    public GameObject[] health;                 // array of heart objects
    public GameObject healthToSpawn;            // object health to spawn


    void Start()
    {

        int itemChanceRoll = Random.Range(0, 100);          // sets the item chance to roll randomly between 0 - 100

        /** if the item chance to roll is greater than or equal to 100 - the chance to spawn hearts, enable the heart and instantiate it
         * else if, disable the heart renderer
        **/
        if (itemChanceRoll >= 100 - chanceToSpawnHealth)
        {

            GetComponent<Renderer>().enabled = true;
            healthToSpawn = health[Random.Range(0, health.Length - 1)];
        }
        else
        {

            GetComponent<Renderer>().enabled = false;
        }
    }

   
}
