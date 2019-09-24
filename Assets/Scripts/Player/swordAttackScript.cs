using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class swordAttackScript : MonoBehaviour
{
	private float timeBtwnAttack;
	public float startTimeBtwAttack;
	
	public Transform attackPos;
	public float attackRange;
	public LayerMask whatIsEnemies;
	public int damage=1;
	
    // Start is called before the first frame update
	void Update(){
	   if(timeBtwnAttack<=0){
		   
		   if(Input.GetKey(KeyCode.Z)){
			   Debug.Log("Attacking...");
			  Collider2D[] enemiesToDamage=Physics2D.OverlapCircleAll(attackPos.position,attackRange,whatIsEnemies);
			  for(int i = 0; i<enemiesToDamage.Length;i++)
			  {
				  enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
			  }
			  timeBtwnAttack=startTimeBtwAttack;
		   }
		   
	   }
	   else{
		   timeBtwnAttack-=Time.deltaTime;
		}
	}
	void OnDrawGizmosSelected()
	{
		Gizmos.color=Color.red;
		Gizmos.DrawWireSphere(attackPos.position,attackRange);
	}
}