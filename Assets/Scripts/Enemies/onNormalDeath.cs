using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onNormalDeath : MonoBehaviour
{
	private int hp;
    

    void Update(){
		hp = gameObject.GetComponent<Enemy>().health;
		if(hp <= 0){
            Debug.Log("Killing Enemy");
            if (GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarCurr < GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarMax)
            {
                GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarCurr = GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarCurr + 10;
            }
            Destroy(gameObject);
		}
	}
}

