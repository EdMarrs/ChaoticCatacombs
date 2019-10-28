using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.GetComponent<Collider2D>().tag == "Player")
        {

            GameObject.Find("Player").GetComponent<PlayerController>().speed = GameObject.Find("Player").GetComponent<PlayerController>().speed + 5;
            Destroy(gameObject);

        }
    }
}
