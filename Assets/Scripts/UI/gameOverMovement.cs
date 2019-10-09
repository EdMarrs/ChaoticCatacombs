using System;
using UnityEngine;

public class gameOverMovement : MonoBehaviour
{
    public float speed;
	public float finalCount;
	public int counter=0;
	private Rigidbody2D rb2d;
    public GameObject restart;
    // Start is called before the first frame update
    void Start(){
		rb2d = GetComponent<Rigidbody2D> ();
        //Instantiate(restart, new Vector3(transform.position.x, transform.position.y - 5, -1), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
	
    {
		
    	
		if (counter < finalCount){
			
			
			counter++;
		}
        
		else if (counter==finalCount){
            Instantiate(restart, new Vector3(transform.position.x, transform.position.y - 5, -1), Quaternion.identity);
           
            counter++;
        }
	}
}
