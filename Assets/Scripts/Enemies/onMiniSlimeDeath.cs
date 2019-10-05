using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMiniSlimeDeath : MonoBehaviour
{
	private int hp;
	public GameObject miniSlime;
    
	void Update(){
		hp = gameObject.GetComponent<Enemy>().health;
		if(hp <= 0){
			 Destroy(gameObject);
		}
	}
}

