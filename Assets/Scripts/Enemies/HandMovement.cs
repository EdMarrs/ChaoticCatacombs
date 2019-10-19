using UnityEngine;
using System.Collections;

public class HandMovement : MonoBehaviour {

public gameObject Hand;

private var Xpos; // : float --> get hands x posititon;
private var Ypos; // : float --> get hands y position;
private var max; // : boolean --> will check if object at maxAmount to flip direction;

var Vert; // :boolean --> Check to move up and down, uncheck for left/right;
var maxAmount; // : int --> Limit to how many unity units to move before checking max; 
var step = 1.0; // : float --> speed of movement; 
// var placeHolder; : int --> add one to it every time it reaches its maxAmount;
                    //(HAVE TO ADD placeHolder functionality still)
var handHealth = getComponent<handBoss>(HP) //might have to check HP each time value is used, rather than declaring it once... 

    void Start() {
        Xpos = transform.position.x; //enemy pos
        Ypos = transform.position.y; //enemy pos

        _centre = transform.position; //center of circle stage function
    }

    void FixedUpdate() {

        if(getComponent<Health>(HP) <= 9 && getComponent<Health>(HP) >= 6){ //replace "Health" w/ name of Script 
            stageOne();                                                     //replace "HP" with health value from Script
        }

        if(getComponent<Health>(HP) <= 5 && getComponent<Health>(HP) >= 3){
            stageTwo();
        }

        if(getComponent<Health>(HP) <= 2 && getComponent<Health>(HP) >= 0){
            stageThree();
        }

        if(getComponent<Health>(HP)==0){
            Destroy(gameObject);
        }
    }

    function stageOne() {
                
        if(Vert){
            if(transform.position.y >= Ypos + maxAmount){
                max=true;
            }
            else if (transform.position.y <= Ypos){
                max = false;
            }
        }
 
        else
        {
            if (transform.position.x >= Xpos + maxAmount)
            {
                max = true;
            }
     
            else if (transform.position.x <= Xpos)
            {
                max = false;
            }
        }
 
        if (Vert){
            if (!max)
            {
                transform.position.y += step;
            }
     
            else
            {
                transform.position.y -= step;
            }
        }
 
        else
        {
            if (!max)
            {
                transform.position.x += step;
            }
     
            else
            {
                transform.position.x -= step;
            }
        }
    }

    function stageTwo(){
        private float RotateSpeed = 5f;
        private float Radius = 0.1f;

        private Vector2 _centre;
        private float _angle;

        private void Update(){
            _angle += RotateSpeed * Time.deltaTime;

            var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;

            float centerPoint = offset.transform.position.y;
            float altitude = Hand.transform.position.y;

            transform.position = _centre + offset;

            if(altitude == (centerPoint+1)){
                placeHolder++; 
            }

            if(getComponent<Health>(HP) >= 6 && getComponent<Health>(HP) <= 9){
                stageThree();
            }
        }
    }

    function stageThree(){

        float timeLeft = 8.0f

        clapCheck();

        function clapCheck() { //Definitley gotta fix
            if(timeLeft < 0){ 
                returnPoint = Vector2(transform.position.x, transform.position.y);

                for(int x=0; x<3; x++){
                    if(x==1){
                        step = 5.0;
                        tranform.position = Vector2.MoveTowards(transform.position.x, player.position,
                        step);
                    }
                    if(x==2){
                        step = 1.0;
                        transform.position = returnPoint; //suppose to return back to initial point before clap
                        timeLeft=8.0f;                    //consider using location of bounding box on wall for Vector2 pos
                        clapCheck();                      //recursion until handhealth hits 0
                    }
                }
            } 
        }
        //clapCheck() function 
        //Transform y position to follow player, but not x position
        //have timer, and after 5 seconds, stop y position and clap inwards
        //move back out
        //placeHolder++;
        //reset until placeHolder == 9; 
    }
}