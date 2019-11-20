using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDropItem : MonoBehaviour
{ 


    // Update is called once per frame
    private int hp;
    public int chanceToSpawnAnItem = 20;
    public GameObject[] items;
    void Update()
    {
        hp = gameObject.GetComponent<Enemy>().health;
        if (hp <= 0)
        {
            
            Destroy(gameObject);

            int itemChanceRoll = Random.Range(0, 100);

            if (itemChanceRoll >= 100 - chanceToSpawnAnItem)
            {
                GetComponent<Renderer>().enabled = true;
                GameObject itemToSpawn = items[Random.Range(0, items.Length - 1)];
                Instantiate(itemToSpawn, new Vector3(transform.position.x, transform.position.y + 1.1f), Quaternion.identity);

            }
            else
            {
                GetComponent<Renderer>().enabled = false;
            }
        }
    }
}
