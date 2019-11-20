using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollideWithPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.GetComponent<Collider2D>().tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
