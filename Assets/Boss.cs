using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Vector3 pos1 = new Vector3(0, 2, 2);
    public Vector3 pos2 = new Vector3(0, 2, 0);
    public int health = 3;
 //   public GameObject blood;
    private Rigidbody2D rb;
 //   public float thrust;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Move from the background into where the player can hit them
        if (Boss1Phase3.lHandDead && Boss1Phase3.rHandDead == true)
        {
            transform.position = Vector3.Lerp(pos2, pos1, Time.deltaTime);
        }



        //Die
        health = gameObject.GetComponent<Enemy>().health;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }

    public void TakeDamage(int damage)
    {
     //   Instantiate(blood, transform.position, Quaternion.identity);
        health -= damage;
        Debug.Log("Damage Taken by Boss");
    }
}
