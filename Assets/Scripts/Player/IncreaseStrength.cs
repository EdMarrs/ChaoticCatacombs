using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseStrength : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.GetComponent<Collider2D>().tag == "Player")
        {

            GameObject.Find("Player").GetComponent<whipAttackScript>().damage = GameObject.Find("Player").GetComponent<whipAttackScript>().damage + 1;
            Destroy(gameObject);

        }
    }
}
