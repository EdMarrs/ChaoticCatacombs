using UnityEngine;
using System.Collections; 

public class PhaseOne : Monbehavior {
    public int fallSpeed = 15;
    public GameObject player;
    public float riseSpeed = 5;

    private Vector3 startingLocation;
    private Vector2 fallDirection;

    private bool isFalling = false;
    private bool wait = false;
    private float waitTime = 5.0f; 

    public void start(){
        startPos = transform.position;
    }

    public void restart(){
        transform.position = startPos;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            GetComponentInParent<PhaseOneAI>().OnPlayerEnter();
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
     GetComponentInParent<PhaseOneAI>().OnTExit(collision);
    }
   
    void slamDown(){

    }
    void rise(){

    }
}