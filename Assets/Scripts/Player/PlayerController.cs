using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{	 
    public float speed;                     // sets the speed
    private Rigidbody2D rb2d;               // sets the rigid body (for 2D object)
    private Animator anim;                  // sets walking animation
	 
	public float jumpForce=35;              // sets the jump to 35
	public bool isGrounded;                 // checks if the player is on the ground
	public Transform groundCheck;           // checks the ground
	public float checkRadius;               // checks the radius around the player
	public LayerMask whatIsGround;          // checks if the layer is ground
    public AudioClip jumpSound;             // sets the jumping sound
    AudioSource audioSource;                // audio
    internal static int moveInput;          // sets the move input


    /**** on load, initializes the rigid body ****/
    void Awake()
    {

        rb2d = GetComponent<Rigidbody2D>();
    }
    /**** at the start of the scene, set the audio and animation ****/
    void Start()
    {

        // need to set audio source to use singular audio clip
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }
    /**** for physics calculations, checks for jump and movement ****/
    void FixedUpdate()
    {

		isGrounded=Physics2D.OverlapCircle(groundCheck.position,checkRadius,whatIsGround);      //Jump Check

        Move();        //Handle Player Movement
    }
    /**** updates every frame ****/
	void Update()
    {

        /** if the input is up arrow or some gamepad button, jump **/
		if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("joystick button 0"))
        {

			Jump();
        }
	}
    /**** handles movement ****/
	void Move()
    {

        float moveInput = Input.GetAxis("Horizontal");                          // handles movement on the X-axis

        // sets the rigid body's velocity to input * speed and the velocity of the rigid body on the Y-axis
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);


        /** if the animation is not facing right and the move input is greater than 0, set to true and flip the image
         * else if the animation is facing right and the move input is less than 0, set to false and flip the image
        **/
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
    /**** handles jumping ****/
	void Jump()
    {

        /** if grounded is true, set the velocity to be up * the jump force and set the audio to the jumping SFX **/
        if (isGrounded == true)
        {

            rb2d.velocity = Vector2.up * jumpForce;
            audioSource.PlayOneShot(jumpSound, 1F);
        }
	}
    /**** flips the image ****/
    public void Flip()
    {

        Vector3 Scaler = transform.localScale;          // scales the image
        Scaler.x *= -1;                                 // multiplies the X-axis scaling by -1
        transform.localScale = Scaler;                  // sets the local scale to the scaler
    }
}

