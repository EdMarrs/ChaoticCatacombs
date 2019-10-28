using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartPickupScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.GetComponent<Collider2D>().tag == "Player")
        {
            if (GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().numberOfHearts < 5)
            {
                GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().numberOfHearts = GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().numberOfHearts+1;
            }
            if (GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().health < 5)
            {
                GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().health = GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().health + 1;
            }
            Destroy(gameObject);
        }
    }
}
