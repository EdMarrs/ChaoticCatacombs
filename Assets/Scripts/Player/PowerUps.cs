using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {
    /*public GameObject speedP;
    public GameObject shieldP;
    public GameObject attackP;
    public GameObject jumpP;

    public float timeLeft = 10.0f;   
    
    // needs a method

       if (Collision.speedP.name == "Player") {
            timeLeft -= Time.deltaTime;
            
           Destory(speedP);
           GetComponent<Player>("step") = 2.0;
           if ( timeLeft < 0 ){
               GetComponent<Player>("step") = 1.0;
               timeLeft = 8.0f;
           }
       }

       if (Collision.shieldP.name == "Player"){
           Destroy(shieldP);
            if(GetComponent<Player>("health")){
                GetComponent<Player>("health")+=1;
           }
            else
            {
                return;
            }
       }

       if(Collision.attackP.name == "Player") {
           for(int i = 0; i<2; i++){
                if(i=0)
                    timeLeft = 10.0f;
                if(i=1)
                    timeLeft -= Time.deltaTime;
           }

           Destroy(attackP);
           GetComponent<Player>("damage") += 1;
           if(timeLeft < 0){
               GetComponent<Player>("damage") -= 1;
               timeLeft = 8.0f;
               return;
           }
        }

        if(Collision.jumpP.name == "Player"){
            Destroy(jumpP);
            timeLeft -= deltaTime;

            GetComponent<Player>("jumpForce") += 5;
            if(timeLeft < 0) {
                GetComponent<Player>("jumpForce") -= 5;
                timeLeft = 8.0f;
                return;
            }
        }*/
}