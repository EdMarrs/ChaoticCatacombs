using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class PlayerIsHitMultiplayer : MonoBehaviour
{
    public int health = 3;                // sets player health to 3 hearts
    public GameObject player;             // sets player object
    private bool iFrames = false;         // sets player frames to false
    private float iTime = 3f;             // sets time to 3 s
    private float iCounter = 0;           // sets counter to 0
    public GameObject blood;              // sets blood particle object
    public GameObject GameOver;           // sets game over object

    public int numberOfHearts;            // sets # of hearts

    public Image[] hearts;                // sets an array of heart images
    public Sprite fullHeart;              // sets a full heart
    public Sprite emptyHeart;             // sets an empty heart

    public AudioClip hurtSound;           // sets a hurt sound
    AudioSource audioSource;              // audio

    GameObject test;                      // sets test object


    /**** when another objects sets off the collider's trigger (for 2D objects), passes a collider (for 2D objects) ****/
    private void OnTriggerEnter2D(Collider2D c)
    {

        /** if there's no frames, grab the enemy tag **/
        if (!iFrames)
        {

            /** if the collider's tag is enemy, set the audio and decrement health according to damage **/
            if (c.GetComponent<Collider2D>().tag == "enemy")
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(hurtSound, 1F);

                health -= 1;                                 // decrement health
                // instantiates blood particles, moves by current position, sets rotation to 0
                Instantiate(blood, transform.position, Quaternion.identity);
                Debug.Log("the player has been hit");        // prints successful in the Console
                iFrames = true;                              // sets the frames to true
                Debug.Log("invincible");                     // prints successful in the Console
                StartCoroutine(Blink());                     // blinks the image
            }
        }
    }
    /**** updates every frame ****/
    void Update()
    {

        /** if health is greater than the # of heats, set health equal to the # of hearts **/
        if (health > numberOfHearts)
        {
            health = numberOfHearts;
        }
        /** if health is less than or equal to 0, exit multiplayer **/
        if (health <= 0)
        {
            //Instantiate(GameOver, new Vector3(Camera.main.gameObject.transform.position.x, Camera.main.gameObject.transform.position.y + 2, -1), Quaternion.identity);
            PhotonNetwork.Disconnect();                                     // disconnect from the other player
            PhotonNetwork.LeaveRoom();                                      // leave the room
            PhotonNetwork.LeaveLobby();                                     // leave the lobby

            health = 3;                                                     // set health to 3
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);          // go back to the main menu


        }
        /** if frames are true, increment the counter by Time **/
        if (iFrames == true) {
            iCounter += Time.deltaTime;

        }
        /** if counter is greater than or equal to time, set counter to 0 and frames to false **/
        if (iCounter >= iTime) {
            iCounter = 0;
            iFrames = false;
            Debug.Log("not invincible");
        }
    }
    /**** iterates blinking ****/
    public IEnumerator Blink()
    {
        var endTime = Time.time + 3.0f;       // sets end time to current time + 3


        /*** while current time is less than end time, disable the player renderer ***/
        while (Time.time < endTime)
        {

            player.GetComponent<Renderer>().enabled = false;        // set the player renderer to false
            yield return new WaitForSeconds(0.2f);
            player.GetComponent<Renderer>().enabled = true;         // set the player renderer to tue
            yield return new WaitForSeconds(0.2f);
        }
    }

}



