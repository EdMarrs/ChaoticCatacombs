using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public int health=3;
	public GameObject blood;
	private Rigidbody2D rb;
	public float thrust;





    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
  
    }
   
	public void TakeDamage(int damage){
		Instantiate(blood, new Vector3(transform.position.x, transform.position.y, -9), Quaternion.identity);
        //     rb.Addforce(new Vector2("x axis", "y axis"));
        

        health -=damage;
     
        Debug.Log("Damage Taken");
    }

   
}
