using UnityEngine; 
using System.Collections;
using UnityEngine.UI; 

public class dialogueManager : MonoBehaviour 
{

	[TextArea(10, 20)]                          // sets a text area of size 10 x 20 units
    public string[] tips;                       // an array of tips

    private BoxCollider2D playerRef;            // a collider that references the player
    private BoxCollider2D room1;                // a collider that encompasses a given room
    private BoxCollider2D room2;                // a collider that encompasses a given room
    private BoxCollider2D room3;                // a collider that encompasses a given room
    private BoxCollider2D room4;                // a collider that encompasses a given room
    private BoxCollider2D room6;                // a collider that encompasses a given room

    /**** at the start of a scene, find the game object ****/
    void Start()
    {
        playerRef = GameObject.Find("Player").GetComponent<BoxCollider2D>();
        room1 = GameObject.Find("RoomOneColl").GetComponent<BoxCollider2D>();
        room2 = GameObject.Find("RoomTwoColl").GetComponent<BoxCollider2D>();
        room3 = GameObject.Find("RoomThreeColl").GetComponent<BoxCollider2D>();
        room4 = GameObject.Find("RoomFourColl").GetComponent<BoxCollider2D>();
        room6 = GameObject.Find("RoomSixColl").GetComponent<BoxCollider2D>();
        GameObject.Find("roomFiveText").GetComponent<Text>().text = tips[4];
        StartCoroutine(delay("roomFiveText"));
    }
    /**** updates every frame ****/
    void Update()
    {
        /** if room 1 is not null, then check if trigger has been set off **/
    	if (room1 != null)
        {
            /** if the player reference is touching room 1, find the text and print out its respective tip **/
            if(playerRef.IsTouching(room1))
            {
            	GameObject.Find("roomOneText").GetComponent<Text>().text = tips[0];
            	StartCoroutine(delay("roomOneText"));
            }
        }
        /** if room 2 is not null, then check if trigger has been set off **/
        if (room2 != null)
        {
            /** if the player reference is touching room 2, find the text and print out its respective tip **/
            if (playerRef.IsTouching(room2))
            {
            	GameObject.Find("roomTwoText").GetComponent<Text>().text = tips[1];
            	StartCoroutine(delay("roomTwoText"));
            }
        }
        /** if room 3 is not null, then check if trigger has been set off **/
        if (room3 != null)
        {
            /** if the player reference is touching room 3, find the text and print out its respective tip **/
            if (playerRef.IsTouching(room3))
            {
            	GameObject.Find("roomThreeText").GetComponent<Text>().text = tips[2];
            	StartCoroutine(delay("roomThreeText"));
            }
        }
        /** if room 4 is not null, then check if trigger has been set off **/
        if (room4 != null)
        {
            /** if the player reference is touching room 4, find the text and print out its respective tip **/
            if (playerRef.IsTouching(room4))
            {
            	GameObject.Find("roomFourText").GetComponent<Text>().text = tips[3];
            	StartCoroutine(delay("roomFourText"));
            }
        }
        /** if room 6 is not null, then check if trigger has been set off **/
        if (room6 != null)
        {
            /** if the player reference is touching room 6, find the text and print out its respective tip **/
            if (playerRef.IsTouching(room6))
            {
            	GameObject.Find("roomSixText").GetComponent<Text>().text = tips[5];
            	StartCoroutine(delay("roomSixText"));
            }
        }
    }
    /**** iteraetes delays, passes the room name ****/
    IEnumerator delay(string room)
    {
    	for (int i = 0; i < 850; i++)
    		yield return null;
    	GameObject.Find(room).GetComponent<Text>().text = "";
        BoxCollider2D temp = GameObject.Find(room).GetComponent<BoxCollider2D>();
        if (temp != null)
            Destroy(temp);
    }


}