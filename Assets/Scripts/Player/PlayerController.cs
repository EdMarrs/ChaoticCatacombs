using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{	 
    public float speed;
    private Rigidbody2D rb2d;
    private Animator anim;
	 
	 public float jumpForce=35;
	 public bool isGrounded;
	 public Transform groundCheck;
	 public float checkRadius;
	 public LayerMask whatIsGround;
     public AudioClip jumpSound;
     AudioSource audioSource;
    internal static int moveInput;
    //
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();

       // DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        // need to set audio source to use singular audio clip
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();

        
    }


    void FixedUpdate()
    {
		//Jump Check
		isGrounded=Physics2D.OverlapCircle(groundCheck.position,checkRadius,whatIsGround);
		
		//Handle Player Movement
        Move();
		
		
		
		
    }
	void Update(){
		if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("joystick button 0")){
			Jump();
        }
		
		
			
		
	}
	void Move(){
        float moveInput = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);

        if ((anim.GetBool("facingRight") == false) && (moveInput > 0))
        {
            anim.SetBool("facingRight", true);
            Flip();
        }
        else if ((anim.GetBool("facingRight") == true) && (moveInput < 0))
        {
            anim.SetBool("facingRight", false);
            Flip();
        }


    }
	void Jump(){
		
		if(isGrounded==true){
			rb2d.velocity=Vector2.up*jumpForce;
            audioSource.PlayOneShot(jumpSound, 1F);
        }
		
	}

    public void Flip()
    {
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}

