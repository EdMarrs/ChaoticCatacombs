using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getItem : MonoBehaviour
{
    public AudioClip ItemSound;             // sets audio for obtaining an item
    AudioSource audioSource;                // audio


    /**** on collider triggered (for 2D objects), passes collider (for 2D objects) ****/
    private void OnTriggerEnter2D(Collider2D c)
    {

        /** if the collider's tag it "items", set the audio to the item sound **/
        if (c.GetComponent<Collider2D>().tag == "items")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(ItemSound, 1F);
        }
    }
}
