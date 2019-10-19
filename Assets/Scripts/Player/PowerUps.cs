Using UnityEngine;
Using System.Collections;

public class PowerUps : Monobehaviour {
    public gameObject speedP;
    public gameObject shieldP;
    public gameObject attackP;
    public gameObject jumpP;

    public float timeLeft = 10.0f;    

       if (Collision.speedP.name == "Player") {
            timeLeft -= Time.deltaTime;
            
           destory(speedP);
           getComponent<Player>("step") = 2.0;
           if ( timeLeft < 0 ){
               getComponent<Player>("step") = 1.0;
               timeLeft = 8.0f;
           }
       }

       if (Collision.shieldP.name == "Player"){
           destroy(shieldP);
            if(getComponent<Player>("health")){
                getComponent<Player>("health")+=1;
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

           destroy(attackP);
           getComponent<Player>("damage") += 1;
           if(timeLeft < 0){
               getComponent<Player>("damage") -= 1;
               timeLeft = 8.0f;
               return;
           }
        }

        if(Collision.jumpP.name == "Player"){
            destroy(jumpP);
            timeLeft -= deltaTime;

            getComponent<Player>("jumpForce") += 5;
            if(timeLeft < 0) {
                getComponent<Player>("jumpForce") -= 5;
                timeLeft = 8.0f;
                return;
            }
        }
}