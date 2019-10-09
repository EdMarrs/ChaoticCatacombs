using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerIsHit : MonoBehaviour
{
	public int health=3;
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

    

    private void OnTriggerEnter2D(Collider2D c)
    {
		if(!iFrames){
		if(c.GetComponent<Collider2D>().tag == "enemy")
         {
                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(hurtSound, 1F);

           health-=1;
		   Instantiate(blood, transform.position, Quaternion.identity);
           Debug.Log("the player has been hit");
		   iFrames=true;
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
       for(int i = 0; i < hearts.Length; i++)
       {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

       }


       if(health <=0) {
		   Instantiate(GameOver,new Vector3(transform.position.x, transform.position.y+4, -1) , Quaternion.identity);
		   Destroy(player);
		   
		   
	   }
	   if(iFrames==true){
		   
		iCounter += Time.deltaTime;

		}
		if (iCounter >= iTime){
			iCounter = 0;
			iFrames = false;
			Debug.Log("not invincible");
	   }
	}
    public IEnumerator Blink() {
		var endTime=Time.time + 3.0f;
		while(Time.time<endTime){
			
			player.GetComponent<Renderer>().enabled = false;
			yield return new WaitForSeconds(0.2f);
			player.GetComponent<Renderer>().enabled = true;
			yield return new WaitForSeconds(0.2f);
		}	
	}
	
  }
	


