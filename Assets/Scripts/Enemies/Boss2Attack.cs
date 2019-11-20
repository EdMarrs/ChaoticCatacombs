using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Attack : MonoBehaviour
{
	float attackTimer = 0f;
	float x;
	public GameObject bossSpike;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(gameObject.GetComponent<Boss2Stats>().phase==1){
		if(attackTimer <= 0f){
			attackTimer = 3f;
		}
		 if(attackTimer > 0f){
			attackTimer -= Time.deltaTime;
			if(attackTimer <= 0f){
				spikeAttack();
			}
		}	
	}
	else if(gameObject.GetComponent<Boss2Stats>().phase==2){
		if(gameObject.GetComponent<Boss2Stats>().phase==1){
		if(attackTimer <= 0f){
			attackTimer = 2f;
		}
		 if(attackTimer > 0f){
			attackTimer -= Time.deltaTime;
			if(attackTimer <= 0f){
				spikeAttack();
			}
		}	
	}	
			
	}
	else if (gameObject.GetComponent<Boss2Stats>().phase==3){
			if(gameObject.GetComponent<Boss2Stats>().phase==1){
		if(attackTimer <= 0f){
			attackTimer = 1f;
		}
		 if(attackTimer > 0f){
			attackTimer -= Time.deltaTime;
			if(attackTimer <= 0f){
				spikeAttack();
				
			}
		}	
	}
	} 
    }
	void spikeAttack(){
		attackTimer=0f;
		Debug.Log("Casting a spike yo");
		x = Random.Range(-25, 26);
		Instantiate(bossSpike, transform.position + new Vector3(x, 50, 0), Quaternion.identity);
	}
}
