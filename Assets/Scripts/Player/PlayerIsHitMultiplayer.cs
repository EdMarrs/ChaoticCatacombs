using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class PlayerIsHitMultiplayer : MonoBehaviour
{
    public int health = 3;
    public GameObject player;
    private bool iFrames = false;
    private float iTime = 3f;
    private float iCounter = 0;
    public GameObject blood;
    public GameObject GameOver;

    public int numberOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public AudioClip hurtSound;
    AudioSource audioSource;

    GameObject test;





    private void OnTriggerEnter2D(Collider2D c)
    {

        if (!iFrames)
        {
            if (c.GetComponent<Collider2D>().tag == "enemy")
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(hurtSound, 1F);

                health -= 1;
                Instantiate(blood, transform.position, Quaternion.identity);
                Debug.Log("the player has been hit");
                iFrames = true;
                Debug.Log("invincible");
                StartCoroutine(Blink());
            }
        }
    }



    void Update()
    {

        if (health > numberOfHearts)
        {
            health = numberOfHearts;
        }
        

        if (health <= 0)
        {
            //Instantiate(GameOver, new Vector3(Camera.main.gameObject.transform.position.x, Camera.main.gameObject.transform.position.y + 2, -1), Quaternion.identity);
            
           
            Destroy(player);


        }
        if (iFrames == true)
        {

            iCounter += Time.deltaTime;


        }
        if (iCounter >= iTime)
        {

            iCounter = 0;
            iFrames = false;
            Debug.Log("not invincible");
        }
    }
    public IEnumerator Blink()
    {
        var endTime = Time.time + 3.0f;
        while (Time.time < endTime)
        {

            player.GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(0.2f);
            player.GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(0.2f);
        }
    }

}



