using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class whipAttackScript : MonoBehaviour
{
    private float timeBtwnAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public float attackRangeX;
    public float attackRangeY;
    public LayerMask whatIsEnemies;
    public int damage = 1;
    private Animator anim;
    private Animator playerAnim;
    public GameObject whip;
    public AudioClip attackSound;
    AudioSource audioSource;


   

    void Start()
    {
        anim = whip.GetComponent<Animator>();
        playerAnim = GameObject.Find("Player").GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Update()
    {
        if (timeBtwnAttack <= 0)
        {

            if (Input.GetKey(KeyCode.Z))
            {
                anim.SetTrigger("usingWhip");
                playerAnim.SetTrigger("isAttacking");
                audioSource.PlayOneShot(attackSound, 1F);


                Collider2D[] enemiesToDamage = Physics2D.OverlapBoxAll(attackPos.position, new Vector2(attackRangeX,attackRangeY),0, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
                timeBtwnAttack = startTimeBtwAttack;
            }
            

        }
        else
        {
            
            timeBtwnAttack -= Time.deltaTime;
            
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(attackPos.position, new Vector2(attackRangeX, attackRangeY));
    }
}