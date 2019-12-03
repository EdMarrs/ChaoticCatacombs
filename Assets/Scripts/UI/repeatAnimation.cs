using System;
using UnityEngine;

public class repeatAnimation : MonoBehaviour
{
    Animation anim;     // sets animation
    float delay;        // sets delay
    float timer;        // sets timer

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animation>();               // gets the animation 
        playAnim();                                     // plays the animation
        delay = anim.clip.length + 1f;                  // delays the clip by 1
        InvokeRepeating("playAnim", 1f, delay);         // invokes repeating the animation and the delay
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    /**** plays the animation ****/
    void playAnim()
    {

    	anim.Play();
    }
}
