using UnityEngine;
using System.Collections; 

/*  public class PhaseOne : Monbehavior {
    public int fallSpeed = 15;
    public GameObject player;
    public float regSpeed = 5;

    private Vector3 pointOne = new Vector3(0, 0, 0);
    private Vector2 pointTwo = new Vector3(5, 0, 0);

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
            slamDown();
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
     GetComponentInParent<PhaseOneAI>().OnTExit(collision);
    }
   
    void sideToSide(){
         transform.position = Vector3.Lerp (pointOne, pointTwo, Mathf.PingPong(Time.time*speed, 1.0f));
    }

    void slamDown(){
        regSpeed = fallSpeed;
        transform.position.Vector3(transform.posx, 0, 0);
        waitTime -= Time.deltaTime;
        if(waitTime == 0)
            rise(); 
    }
    void rise(){
        transform.position(pointOne);
        waitTime = 5.0f;
        regSpeed = 5;
        sideToSide();
    }
} */ 