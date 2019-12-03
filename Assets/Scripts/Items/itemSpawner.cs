using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawner : MonoBehaviour
{
    public int chanceToSpawnAnItem=20;          // sets the spawn rate to 20%
    public GameObject[] items;                  // array of item objects
    
    // Start is called before the first frame update
    void Start()
    {

        int itemChanceRoll = Random.Range(0, 100);          // set the item chance rate randomly between 0 - 100
        
        /** if the item chance rolls are less than 100 - the chance to spawn, enable the random item and instantiate it 
         * else if, disable the item renderer
        **/
        if(itemChanceRoll >= 100 - chanceToSpawnAnItem)
        {
            GetComponent<Renderer>().enabled = true;                            // enable the item to be visible
            GameObject itemToSpawn= items[Random.Range(0, items.Length-1)];     // set the item to be spawned to be randomly generated
            // instantiate the item itself, its position along the X and Y-axes, and rotation of 0
            Instantiate(itemToSpawn, new Vector3(transform.position.x, transform.position.y + 1.1f), Quaternion.identity);

        }
        else
        {
            GetComponent<Renderer>().enabled = false;       // disable the item's visibility
        }
    }
    

   
}
