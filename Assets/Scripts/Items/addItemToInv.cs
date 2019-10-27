using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addItemToInv : MonoBehaviour
{
    public GameObject itemToAddToInv;
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.GetComponent<Collider2D>().tag == "Player")
        {
                
        }
    }
}
