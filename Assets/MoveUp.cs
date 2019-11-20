using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{

    void Start()
    {
    
    }

    void Update()
    {
        // move platforms down
        transform.position += new Vector3(0 * Time.deltaTime, -1 * Time.deltaTime, 0);


        if (transform.position.y <= -30)
        {
            if (this.gameObject.tag == "Shortboi")
            {

                transform.position = new Vector3(16, -1, 0);
            }

            if (this.gameObject.tag == "Longboi")
            {

                transform.position = new Vector3(12, -1, 0);
            }
        }
        
        
    }
}
