using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onSlimeDeath : MonoBehaviour
{
	private int hp;
	public GameObject miniSlime;
    // Start is called before the first frame update
    void Start()
    {
        
		
    }
	void Update(){
		hp = gameObject.GetComponent<Enemy>().health;
		if(hp <= 0){
			Debug.Log("Hit");
			 Instantiate(miniSlime, transform.position + new Vector3(0, 0, 0), Quaternion.identity);
			 
			 Destroy(gameObject);
		}
	}
}
