using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawner : MonoBehaviour
{
    public int chanceToSpawnAnItem=20;
    public GameObject[] items;
    
    // Start is called before the first frame update
    void Start()
    {

        
        int itemChanceRoll = Random.Range(0, 100);
        
        if(itemChanceRoll>= 100 - chanceToSpawnAnItem)
        {
            GetComponent<Renderer>().enabled = true;
            GameObject itemToSpawn= items[Random.Range(0, items.Length-1)];
            Instantiate(itemToSpawn, new Vector3(transform.position.x, transform.position.y + 1.1f), Quaternion.identity);

        }
        else
        {
            GetComponent<Renderer>().enabled = false;
        }
    }
    

   
}
