using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMana : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.GetComponent<Collider2D>().tag == "Player")
        {

            GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarMax = GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarMax + 50;
            GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarCurr = GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarMax;
            Destroy(gameObject);

        }
    }
}
