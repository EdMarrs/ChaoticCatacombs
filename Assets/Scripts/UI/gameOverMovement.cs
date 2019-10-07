using System;
using UnityEngine;

public class gameOverMovement : MonoBehaviour
{
    public float speed;
	public float finalCount;
	public int counter=0;
	private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start(){
		rb2d = GetComponent<Rigidbody2D> ();
	}
    // Update is called once per frame
    void Update()
	
    {
		Debug.Log("Hit");
    	
		if (counter < finalCount){
			
			rb2d.velocity=new Vector2(0, speed);
			counter++;
		}
		else{
			rb2d.velocity=new Vector2(0, 0);
		}
	}
}
