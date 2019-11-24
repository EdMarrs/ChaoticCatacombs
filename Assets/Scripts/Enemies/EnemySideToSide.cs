using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySideToSide : MonoBehaviour{
    public float speed;
	
	public float leftMove;
	public float rightMove;
   
    private bool isGoingRight;
	private Rigidbody2D rb2d;
	private float leftWayPoint;
	private float rightWayPoint;
	Vector3 localScale;

    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;




    public Vector3 velCopy;
	
	void Awake()
    {
        int startDir = Random.Range(0, 2);
        if (startDir == 0)
        {
            isGoingRight = true;
        }
        else if (startDir == 1)
        {
            isGoingRight = false;
        }
        rb2d = GetComponent<Rigidbody2D> ();
		leftWayPoint=transform.position.x-leftMove;
		rightWayPoint=rightMove+transform.position.x;
        
		
    }




    void Update()
    {
        //check to see if enemy is touching the ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        if (isGrounded == true)
        {


            if (transform.position.x >= rightWayPoint)
            {
                isGoingRight = false;

            }
            if (transform.position.x <= leftWayPoint)
            {

                isGoingRight = true;
            }

            if (isGoingRight == true)
            {
                moveRight();
            }
            if (isGoingRight == false)
            {
                moveLeft();
            }

            velCopy = rb2d.velocity;
        }

        void FixedUpdate()
        {
            //check to see if enemy is touching the ground
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        }
    }
	void moveRight(){

		rb2d.velocity=new Vector2(speed, 0.0f);
	}
	void moveLeft(){

		rb2d.velocity=new Vector2(-speed, 0.0f);
	}
}
