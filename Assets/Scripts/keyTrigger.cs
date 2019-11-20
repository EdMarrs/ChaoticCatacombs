using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger : MonoBehaviour
{
    public int key = 0;
    private BoxCollider2D playerRef;
    private BoxCollider2D room1;
    private BoxCollider2D room2;
    private BoxCollider2D room3;
    private BoxCollider2D room4;

    void Start()
    {
        playerRef = GameObject.Find("Player").GetComponent<BoxCollider2D>();
        room1 = GameObject.Find("RoomOneColl").GetComponent<BoxCollider2D>();
        room2 = GameObject.Find("RoomTwoColl").GetComponent<BoxCollider2D>();
        room3 = GameObject.Find("RoomThreeColl").GetComponent<BoxCollider2D>();
        room4 = GameObject.Find("RoomFourColl").GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (room1 != null)
        {
            if(playerRef.IsTouching(room1))
            {
                key++;
                Destroy(room1);
            }
        }
        if (room2 != null)
        {
            if(playerRef.IsTouching(room2))
            {
                key++;
                Destroy(room2);
            }
        }
        if (room3 != null)
        {
            if(playerRef.IsTouching(room3))
            {
                key++;
                Destroy(room3);
            }
        }
        if (room4 != null)
        {
            if(playerRef.IsTouching(room4))
            {
                key++;
                Destroy(room4);
            }
        }
        if(key == 4)
        {
            Destroy(GameObject.Find("MainPlatform_M").GetComponent<BoxCollider2D>());
            GameObject.Find("Open").GetComponent<Renderer>().enabled = true;
        }
    }
}
