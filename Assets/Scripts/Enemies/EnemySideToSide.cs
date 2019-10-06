using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySideToSide : MonoBehaviour{
    public float speed;
	
	public float leftMove;
	public float rightMove;
   
    private bool isGoingRight=true;
	private Rigidbody2D rb2d;
	private float leftWayPoint;
	private float rightWayPoint;
	Vector3 localScale;
	
	
	public Vector3 velCopy;
	
	void Awake()
    {
        rb2d = GetComponent<Rigidbody2D> ();
		leftWayPoint=transform.position.x-leftMove;
		rightWayPoint=rightMove+transform.position.x;
		
    }
	
   
       
    
	 void Update()
    {
		
		
        
        if(transform.position.x >=rightWayPoint){
            isGoingRight=false;
			
		}
        if (transform.position.x <=leftWayPoint){
			
            isGoingRight=true;
        }
		if (isGoingRight==true){
			moveRight();
		}
		if(isGoingRight==false){
			moveLeft();
		}
		
		velCopy = rb2d.velocity;
        
	}
	void moveRight(){

		rb2d.velocity=new Vector2(speed, 0.0f);
	}
	void moveLeft(){

		rb2d.velocity=new Vector2(-speed, 0.0f);
	}
}
