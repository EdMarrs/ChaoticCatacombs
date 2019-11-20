using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummy : MonoBehaviour
{ 
    // Update is called once per frame
	private int hp;
    private Collider2D whipRef;
    private int chanceToSpawnAnItem;
   	public GameObject[] items;
    private int itemChanceRoll; 

    void Start()
    {
    	hp = GameObject.FindObjectOfType<Enemy>().health;
    	whipRef = GameObject.Find("WhipAttackScript").GetComponent<Collider2D>();
    	chanceToSpawnAnItem = 20;
    	itemChanceRoll = Random.Range(0, 100); 
    }

    void Update()
    {

    	if(Physics2D.IsTouching(whipRef, GetComponent<Collider2D>())) {
    		hp -= 1;
    	}

        if (hp == 0)
        {            
            Destroy(gameObject);

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
