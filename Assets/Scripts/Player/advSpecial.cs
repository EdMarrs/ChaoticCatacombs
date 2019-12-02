using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advSpecial : MonoBehaviour
{
    SpriteRenderer sprite;                      // renders the sprite used
    public float SpecialBarCurr = 100f;         // sets the current special bar to 100
    public float SpecialBarMax = 100f;          // sets the max special bar to 100
    private bool UsingSpecial = false;          // checks if the special has been used

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();        // grabs the sprite component

    }

    // Update is called once per frame
    void Update()
    {
        /** if the special has not been used, check the input to activate **/
        if (!UsingSpecial)
        {
            /** if the input is space bar or gamepad button, activate special **/
            if (Input.GetKey(KeyCode.Space) || Input.GetKeyDown("joystick button 2"))
            {

                /** if the current bar is 100, activate special **/
                if (SpecialBarCurr >= 100)
                {
                    SpecialBarCurr -=100;                       // decrement the current bar
                    UsingSpecial = true;                        // activate the special
                    StartCoroutine(ActivatedSpecial());
                }
            }
        }
        else
        {
            //Tried to do special ability and failed
        }
    }
    /**** iterates activated special ****/
    public IEnumerator ActivatedSpecial()
    {
        Debug.Log("hit special");                                                           // prints successful in Console
        int attackVal = gameObject.GetComponent<whipAttackScript>().damage;                 // sets attack value using the whipAttackScript
        int normalAttackVal = gameObject.GetComponent<whipAttackScript>().damage;           // sets normal attack value using the whipAttackScript
        Color normalSpriteColor = sprite.color;                                             // sets the normal sprite color

        var endTime = Time.time + 10.0f;                                                    // sets time of special use to 10 s
        gameObject.GetComponent<whipAttackScript>().damage= attackVal*2;                    // sets the attack value to be 2x as powerful
        sprite.color = new Color(1, 0, 0, 1);                                               // sets color value to R, G, B, A

        /*** while the current time is less than the end time ***/
        while (Time.time < endTime)
        {
            
            yield return new WaitForSeconds(0.1f);
        }
        gameObject.GetComponent<whipAttackScript>().damage= normalAttackVal;                // set back to normal attack value
        sprite.color = normalSpriteColor;                                                   // set bacl to normal sprite color
        Debug.Log("end special");                                                           // prints over in Console
        UsingSpecial = false;                                                               // sets using special to false
    }
}
