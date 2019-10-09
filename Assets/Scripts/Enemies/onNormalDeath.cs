using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onNormalDeath : MonoBehaviour
{
	private int hp;
	
    
	void Update(){
		hp = gameObject.GetComponent<Enemy>().health;
		if(hp <= 0){
			 Destroy(gameObject);
		}
	}
}

