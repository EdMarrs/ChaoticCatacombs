using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onSlimeDeath : MonoBehaviour
{
	private int hp;
	public GameObject miniSlime;
    private Animator anim;

    public int chanceToSpawnHealth = 50;
    public GameObject healthToSpawn;
    private int itemChanceRoll;

    // Start is called before the first frame update
    void Start()
    {
        itemChanceRoll = Random.Range(0, 100);
        anim = GetComponent<Animator>();
       
    }
	void Update(){
		hp = gameObject.GetComponent<Enemy>().health;
		if(hp <= 0){
            

                // spawns health based on random chance
                if (itemChanceRoll >= 100 - chanceToSpawnHealth)
                {

                    Instantiate(healthToSpawn, new Vector3(transform.position.x, transform.position.y + 1.1f), Quaternion.identity);
                }

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
