using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerCollide : MonoBehaviour
{
	public int numberOfEnemyTypes;              // # of enemy types

    public GameObject[] enemies;                // enemy object
    public int lowerSpawnAmt=1;                 // min spawn amount in an area
    public int upperSpawnAmt=5;                 // max spawn amount in an area

    private bool alreadyTriggered=false;        // checks if the trigger has been set off
    private int numberOfEnemiesToSpawn;         // # of enemies to be spawned
    private int enemyType;                      // sets enemy type
    private Vector3 spawnPosition;              // sets position of the spawn
    
    private float SizeX;                        // size of the enemy on the X-axis
    private float SizeY;                        // size of the enemy on the Y-axis

    public float spawnWithinLeft=2;             // spawns 2 units in the axis
    public float spawnWithinRight = 4;          // spawns 4 units in the axis
   

    // Update is called once per frame
    void Update()
    {
        /*** for the  of enemies, increment ***/
		for(int i = 0; i < enemies.Length; i++)
       {

            /** if i is less than the # of enemy types, set active enemy at i to be true
             * else if, ser active enemy at i to be false
            **/
            if (i < numberOfEnemyTypes)
            {
                enemies[i].SetActive(true);
            }
            else
            {
                enemies[i].SetActive(false);
            }

       }
        
    }
    /**** on the trigger entered (for 2D objects), passing a collider (for 2D objects) ****/
    private void OnTriggerEnter2D(Collider2D c) {


        SizeX = gameObject.GetComponent<Collider2D>().bounds.size.x;        // sets SizeX to grab the collider component and their sizes
        SizeY = gameObject.GetComponent<Collider2D>().bounds.size.y;        // sets SizeY to grab the collider component and their sizes

        /** if when grabbing the collider component's tag is "Player", then check if it's been triggered **/
        if (c.GetComponent<Collider2D>().tag == "Player") {
            
            /** if it hasn't been triggered, set to true and spawn enemies **/
            if (!alreadyTriggered)
                {
                    
                    alreadyTriggered = true;
                    numberOfEnemiesToSpawn = Random.Range(lowerSpawnAmt, upperSpawnAmt);
                    /*** for the # of enemies to spawn, increment ***/
                    for(int i = 0; i < numberOfEnemiesToSpawn; i++)
                    {
                        enemyType = Random.Range(0, enemies.Length);
                        // sets the spawn position to a random range on the X-axis, a position on the Y-axis, and 0 on the Z-axis
                        spawnPosition = new Vector3(Random.Range(transform.position.x+spawnWithinLeft, transform.position.x+spawnWithinRight), transform.position.y, 0 );
      
                    
                    // instantiates an enemy of enemy type, a spawn position, and a rotation of 0
                    Instantiate(enemies[enemyType], spawnPosition, Quaternion.identity);
                        
                    }
                }
            
            }
        
    }
}
