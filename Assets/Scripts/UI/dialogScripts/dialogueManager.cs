using UnityEngine; 
using System.Collections;
using UnityEngine.UI; 

public class dialogueManager : MonoBehaviour 
{

	[TextArea(10, 20)]
    public string[] tips;

    private BoxCollider2D playerRef;
    private BoxCollider2D room1;
    private BoxCollider2D room2;
    private BoxCollider2D room3;
    private BoxCollider2D room4;
    private BoxCollider2D room6;


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

    void Update()
    {
    	if (room1 != null)
        {
            if(playerRef.IsTouching(room1))
            {
            	//GameObject.Find("roomOneText").GetComponent<ParticleSystem>().Play();
            	GameObject.Find("roomOneText").GetComponent<Text>().text = tips[0];
            	StartCoroutine(delay("roomOneText"));
            }
        }
        if (room2 != null)
        {
            if(playerRef.IsTouching(room2))
            {
            	GameObject.Find("roomTwoText").GetComponent<Text>().text = tips[1];
            	StartCoroutine(delay("roomTwoText"));
            }
        }
        if (room3 != null)
        {
            if(playerRef.IsTouching(room3))
            {
            	GameObject.Find("roomThreeText").GetComponent<Text>().text = tips[2];
            	StartCoroutine(delay("roomThreeText"));
            }
        }
        if (room4 != null)
        {
            if(playerRef.IsTouching(room4))
            {
            	GameObject.Find("roomFourText").GetComponent<Text>().text = tips[3];
            	StartCoroutine(delay("roomFourText"));
            }
        }
        if (room6 != null)
        {
        	if(playerRef.IsTouching(room6))
            {
            	GameObject.Find("roomSixText").GetComponent<Text>().text = tips[5];
            	StartCoroutine(delay("roomSixText"));
            }
        }
    }

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