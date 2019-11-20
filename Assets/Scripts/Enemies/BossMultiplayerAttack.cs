using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMultiplayerAttack : MonoBehaviour
{
    float attackTimer = 0f;
    float x;
    int numOfBasicAttack = 0;
    public GameObject bossOrb;
    public GameObject homingOrb;
    public float speed = 10f;
    public int homingThresh = 5;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
            if (attackTimer <= 0f)
            {
                attackTimer = 5f/ gameObject.GetComponent<BossMultiplayerStats>().phase;
            }
            if (attackTimer > 0f)
            {
                attackTimer -= Time.deltaTime;
                if (attackTimer <= 0f && numOfBasicAttack < homingThresh)
                {
                    orbAttack();
                    numOfBasicAttack++;
                }
                else if (attackTimer <= 0f && numOfBasicAttack >= homingThresh)
                {
                    homingAttack();
                    numOfBasicAttack = 0;
                }
            }
        
        
    }
    void orbAttack()
    {

        attackTimer = 0f;


        foreach (GameObject playerObj in GameObject.FindGameObjectsWithTag("Player"))
        {



            Debug.Log("Base Orb Throwing");
            Vector2 target = new Vector2(playerObj.GetComponent<Transform>().position.x, playerObj.GetComponent<Transform>().position.y);
            Vector2 myPos = new Vector2(transform.position.x, transform.position.y);

            Vector2 direction = target - myPos;
            direction.Normalize();

            GameObject projectile = Instantiate(bossOrb, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);

            projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;

        }

    }

    void homingAttack()
    {
        attackTimer = 0f;






        GameObject projectile = Instantiate(homingOrb, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);



    }
}
