using System;
using UnityEngine;

public class gameOverMovement : MonoBehaviour
{
    public float speed;                 // sets the speed
	public float finalCount;            // sets the final count
	public int counter = 0;             // sets the counter to 0
	private Rigidbody2D rb2d;           // sets the rigid body
    public GameObject restart;          // sets the restart object


    // Start is called before the first frame update
    void Start()
    {

		rb2d = GetComponent<Rigidbody2D>();         // gets the rigid body component
    }
    // Update is called once per frame
    void Update()
    {

		/** if the counter is less than the final count, increment 
         * else if the counter is equal to the final count, instantiate and increment
        **/
		if (counter < finalCount)
        {
			
			counter++;
		}
		else if (counter==finalCount)
        {

            // instantiate the restart object, set the position on the X and Y-axes, set the rotation to 0
            Instantiate(restart, new Vector3(transform.position.x, transform.position.y - 5, -1), Quaternion.identity);
           
            counter++;
        }
	}
}
