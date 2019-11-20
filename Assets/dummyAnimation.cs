using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyAnimation : MonoBehaviour
{
    public int health = 5;
    public GameObject hay;
    private Rigidbody2D rb;
    public float thrust;
    private Animator anim;





    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();

    }

    public void TakeDamage(int damage)
    {
        anim.SetBool("isHit",true);
        Instantiate(hay, transform.position, Quaternion.identity);

        health -= damage;

        Debug.Log("Damage Taken");
        
    }


}
