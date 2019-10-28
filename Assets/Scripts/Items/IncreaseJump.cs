using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseJump : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.GetComponent<Collider2D>().tag == "Player")
        {

            GameObject.Find("Player").GetComponent<PlayerController>().jumpForce = GameObject.Find("Player").GetComponent<PlayerController>().jumpForce + 5;
            Destroy(gameObject);

        }
    }
}
