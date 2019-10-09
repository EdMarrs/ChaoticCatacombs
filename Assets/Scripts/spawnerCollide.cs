using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerCollide : MonoBehaviour
{
	public int numberOfEnemyTypes;

    public GameObject[] enemies;
    public int lowerSpawnAmt=1;
    public int upperSpawnAmt=5;

    private bool alreadyTriggered=false;
    private int numberOfEnemiesToSpawn;
    private int enemyType;
    private Vector3 spawnPosition;
    
    private float SizeX;
    private float SizeY;

    public float spawnWithinLeft=2;
    public float spawnWithinRight = 4;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
		for(int i = 0; i < enemies.Length; i++)
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
    private void OnTriggerEnter2D(Collider2D c) {


        SizeX = gameObject.GetComponent<Collider2D>().bounds.size.x;
        SizeY = gameObject.GetComponent<Collider2D>().bounds.size.y;

        if (c.GetComponent<Collider2D>().tag == "Player") {
            
            if (!alreadyTriggered)
                {
                    
                    alreadyTriggered = true;
                    numberOfEnemiesToSpawn = Random.Range(lowerSpawnAmt, upperSpawnAmt);
                    for(int i = 0; i < numberOfEnemiesToSpawn; i++)
                    {
                        enemyType = Random.Range(0, enemies.Length);
                        spawnPosition = new Vector3(Random.Range(transform.position.x+spawnWithinLeft, transform.position.x+spawnWithinRight), transform.position.y, 0 );
      
                    

                    Instantiate(enemies[enemyType], spawnPosition, Quaternion.identity);
                        
                    }
                }
            
            }
        
    }
}
