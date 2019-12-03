using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{

    /**** on the load of a scene ****/
    void Start()
    {
    
    }
    /**** updates every frame ****/
    void Update()
    {
        
        transform.position += new Vector3(0 * Time.deltaTime, -1 * Time.deltaTime, 0);      // move platforms down


        /** if the Y-axis position is less than or equal to -30, check the game object's tags **/
        // resets the platforms above of camera so they move in a conveyor-belt fashion
        if (transform.position.y <= -30)
        {

            /** if this object's tag is "Shortboi", set the new position to be 16, -1, and 0 on their respective axes **/
            if (this.gameObject.tag == "Shortboi")
            {

                transform.position = new Vector3(16, -1, 0);
            }
            /** if this object's tag is "Longboi", set the new position to be 12, -1, and 0 on their respective axes **/
            if (this.gameObject.tag == "Longboi")
            {

                transform.position = new Vector3(12, -1, 0);
            }
        }
        
        
    }
}
