using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySideToSide : MonoBehaviour{
    public float speed;
	public float distanceToMove;
    private float locationCounter = 0;
    private bool isGoingRight=true;
	private Rigidbody2D rb2d;
	void Awake()
    {
		
        rb2d = GetComponent<Rigidbody2D> ();
    }
	
    void FixedUpdate()
    {
       
        CheckFlip();
        
    }
	 void CheckFlip()
    {
		if(isGoingRight==true){
          Vector2 movement = new Vector2 (1, 0);
          rb2d.velocity = (movement * speed);
        }
        else{
          Vector2 movement = new Vector2 (-1, 0);
          rb2d.velocity = (movement * speed);
        }
        
        locationCounter++;
        
        if(locationCounter >=distanceToMove){
          if(isGoingRight==true){
            isGoingRight=false;
          }
          else{
            isGoingRight=true;
          }
          locationCounter=0;
        }
	}
}
