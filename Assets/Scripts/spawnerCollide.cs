using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerCollide : MonoBehaviour
{
	public int numberOfEnemyTypes;

    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		for(int i = 0; i < enemies.Length; i++)
       {

            if (i < numberOfEnemyTypes)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

       }
        if(c.GetComponent<Collider2D>().tag == "player")
         {
			 
		 }
    }
}
