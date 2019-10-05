using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{	 public float speed;
     private Rigidbody2D rb2d;
	 
	 
	 private bool facingRight = true;
	 
	 public float jumpForce=20;
	 public bool isGrounded;
	 public Transform groundCheck;
	 public float checkRadius;
	 public LayerMask whatIsGround;
	 
	 
    
	
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
		
        
    }

    
    void FixedUpdate()
    {
		//Jump Check
		isGrounded=Physics2D.OverlapCircle(groundCheck.position,checkRadius,whatIsGround);
		
		//Handle Player Movement
        Move();
		
		
		
		
    }
	void Update(){
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			Jump();
		}
		
		
			
		
	}
	void Move(){
		float moveInput = Input.GetAxis ("Horizontal");
		
		rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
		
		if(facingRight==false&&moveInput>0){
			Flip();
		}
		else if(facingRight==true&&moveInput<0){
			Flip();
		}
	}
	void Jump(){
		
		if(isGrounded==true){
			rb2d.velocity=Vector2.up*jumpForce;
		}
		
	}
	
	void Flip(){
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x*=-1;
		transform.localScale=Scaler;
	}
}

