using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onSlimeDeath : MonoBehaviour
{
	private int hp;
	public GameObject miniSlime;
    private Animator anim;
    public bool triggerDeath;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        triggerDeath = false;
       
    }
	void Update(){
		hp = gameObject.GetComponent<Enemy>().health;
		if(hp <= 0&& triggerDeath==false){
            triggerDeath = true;
            gameObject.GetComponent<EnemySideToSide>().speed = 0;
            gameObject.GetComponent<Rigidbody2D>().isKinematic = false;

            Debug.Log("Hit");
       
            anim.SetBool("isDead", true);
            //Instantiate(miniSlime, transform.position + new Vector3(0, 0, 0), Quaternion.identity);
            if (GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarCurr < GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarMax)
            {
                GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarCurr = GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarCurr + 10;
            }
            Destroy(gameObject,.5f);

            
        }
	}
}
