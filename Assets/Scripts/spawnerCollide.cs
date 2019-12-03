using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerCollide : MonoBehaviour
{
    public int numberOfEnemyTypes;

    public GameObject[] enemies;
    public int lowerSpawnAmt = 1;
    public int upperSpawnAmt = 5;

    private bool alreadyTriggered = false;
    private int numberOfEnemiesToSpawn;
    private int enemyType;
    private Vector3 spawnPosition;

    private float SizeX;
    private float SizeY;

    public float spawnWithinLeft = 2;
    public float spawnWithinRight = 4;

    // Start is called before the first frame update

    void Start()
    {
        numberOfEnemiesToSpawn = Random.Range(lowerSpawnAmt, upperSpawnAmt);
        /*** for the # of enemies to spawn, increment ***/
        for (int i = 0; i < numberOfEnemiesToSpawn; i++)
        {
            enemyType = Random.Range(0, enemies.Length);
            // sets the spawn position to a random range on the X-axis, a position on the Y-axis, and 0 on the Z-axis
            spawnPosition = new Vector3(Random.Range(transform.position.x + spawnWithinLeft, transform.position.x + spawnWithinRight), transform.position.y, 0);


            // instantiates an enemy of enemy type, a spawn position, and a rotation of 0
            Instantiate(enemies[enemyType], spawnPosition, Quaternion.identity);

        }
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < enemies.Length; i++)
        {

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

    /*
    // on the trigger entered (for 2D objects), passing a collider (for 2D objects)
    private void OnTriggerEnter2D(Collider2D c) {


      //  SizeX = gameObject.GetComponent<Collider2D>().bounds.size.x;        // sets SizeX to grab the collider component and their sizes
      //  SizeY = gameObject.GetComponent<Collider2D>().bounds.size.y;        // sets SizeY to grab the collider component and their sizes

        /** if when grabbing the collider component's tag is "Player", then check if it's been triggered 
        if (c.GetComponent<Collider2D>().tag == "Player") {
            
            /** if it hasn't been triggered, set to true and spawn enemies 
=======
    private void OnTriggerEnter2D(Collider2D c) {


        SizeX = gameObject.GetComponent<Collider2D>().bounds.size.x;
        SizeY = gameObject.GetComponent<Collider2D>().bounds.size.y;

        if (c.GetComponent<Collider2D>().tag == "Player") {
            
>>>>>>> 33399adbe225d95032cf9692162e825267c6e7db
            if (!alreadyTriggered)
                {
                    
                    alreadyTriggered = true;
                    numberOfEnemiesToSpawn = Random.Range(lowerSpawnAmt, upperSpawnAmt);
<<<<<<< HEAD
                    /*** for the # of enemies to spawn, increment 
=======
>>>>>>> 33399adbe225d95032cf9692162e825267c6e7db
                    for(int i = 0; i < numberOfEnemiesToSpawn; i++)
                    {
                        enemyType = Random.Range(0, enemies.Length);
                        spawnPosition = new Vector3(Random.Range(transform.position.x+spawnWithinLeft, transform.position.x+spawnWithinRight), transform.position.y, 0 );
      
                    

                    Instantiate(enemies[enemyType], spawnPosition, Quaternion.identity);
                        
                    }
                }
            
            }
        */
    // }
}
