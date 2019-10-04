using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIsHit : MonoBehaviour
{
	public int health=3;
	public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	  private void OnTriggerEnter2D(Collider2D c)
    {
		if(c.GetComponent<Collider2D>().tag == "enemy")
         {
        
           health-=1;
           Debug.Log("the player has been hit");
        
		 }
    }
	
    void Update()
    {
       if(health <=0) {
		   Destroy(player);
		   Debug.Log("Player Killed");
	   }
    }
	
   }
	


