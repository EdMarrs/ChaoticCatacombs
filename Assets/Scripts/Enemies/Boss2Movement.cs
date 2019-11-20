using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Movement : MonoBehaviour
{
  
   private Vector3 startPos;

public float speed = 1;
public float xScale = 1;
public float yScale = 1;

void Start () {
startPos = transform.position;
}

void Update () {
	if(gameObject.GetComponent<Boss2Stats>().phase==1){
			speed=1;
	}
	else if(gameObject.GetComponent<Boss2Stats>().phase==2){
			speed=3;
			
	}
	else if (gameObject.GetComponent<Boss2Stats>().phase==3){
			speed=5;
	}
	
transform.position = startPos + (Vector3.right * Mathf.Sin(Time.timeSinceLevelLoad/2*speed)*xScale
 - Vector3.up * Mathf.Sin(Time.timeSinceLevelLoad * speed)*yScale);
}
}
 


