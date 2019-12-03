using System;
using UnityEngine;

public class repeatAnimation : MonoBehaviour
{
    Animation anim;
    float delay;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        playAnim();
        delay = anim.clip.length + 1f;
        InvokeRepeating("playAnim", 1f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playAnim()
    {
    	anim.Play();
    }
}
