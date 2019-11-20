using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{
    public int chanceToSpawnHealth = 10;
    public GameObject[] health;
    public GameObject healthToSpawn;


    void Start()
    {


        int itemChanceRoll = Random.Range(0, 100);

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
