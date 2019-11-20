using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySpike : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Transform>().position.y < -40)
        {
            Destroy(gameObject);
        }
    }
}

       
