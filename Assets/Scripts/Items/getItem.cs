using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getItem : MonoBehaviour
{
    public AudioClip ItemSound;
    AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.GetComponent<Collider2D>().tag == "items")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(ItemSound, 1F);
        }
    }
}
