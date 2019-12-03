using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class whipAttackScript : MonoBehaviour
{
    private float timeBtwnAttack;           // sets time of attack
    public float startTimeBtwAttack;        // sets the start time of attack

    public Transform attackPos;             // sets the attack position
    public float attackRangeX;              // sets the attack range in the X-axis
    public float attackRangeY;              // sets the attack range in the Y-axis
    public LayerMask whatIsEnemies;         // checks the layer to determine what's an enemy
    public int damage = 1;                  // sets the damage amount
    private Animator anim;                  // sets the weapon animation
    private Animator playerAnim;            // sets the player animation
    public GameObject whip;                 // object for the whip
    public AudioClip attackSound;           // audio for attacking
    AudioSource audioSource;                // audio

    /**** at the start of a scene, set the animations and audio ****/
    void Start()
    {

        anim = whip.GetComponent<Animator>();
        playerAnim = GameObject.Find("Player").GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    /**** updates every frame ****/
    void Update()
    {

        /** if the time of attack is less than or equal to 0, check the input to activate
         * else if, set time of attack to cooldown
        **/
        if (timeBtwnAttack <= 0)
        {

            /** if the input is Z or gamepas button, set the animations and audio **/
            if (Input.GetKey(KeyCode.Z) || Input.GetKeyDown("joystick button 1"))
            {
                anim.SetTrigger("usingWhip");
                playerAnim.SetTrigger("isAttacking");
                audioSource.PlayOneShot(attackSound, 1F);


                // collider that sets enemy damage to attack position, attack range in the X and Y-axes, 0 angle, and enemy layer
                Collider2D[] enemiesToDamage = Physics2D.OverlapBoxAll(attackPos.position, new Vector2(attackRangeX,attackRangeY),0, whatIsEnemies);
                /*** for the enemies's HP, increment ***/
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);        // grab enemy component and damage them
                }

                timeBtwnAttack = startTimeBtwAttack;            // set time of attack to start of time attack
            }
        }
        else
        {
            
            timeBtwnAttack -= Time.deltaTime;
        }
    }
    /**** selects Gizmos in the Scene (Editor) view
     * Gizmo:  for visual debugging in the Scene (Editor) view
    ****/
    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;                                                               // set Gizmo color to red
        // draws wireframe using the attack position and X and Y-axes
        Gizmos.DrawWireCube(attackPos.position, new Vector2(attackRangeX, attackRangeY));
    }
}