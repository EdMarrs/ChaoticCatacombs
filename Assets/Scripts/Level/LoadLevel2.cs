using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour
{

	private BoxCollider2D playerRef;            // sets the collider (for 2D objects) for the player references
	public BoxCollider2D cave;                  // sets the collider (for 2D objects) for the cave


    /**** on the scene load, set the player reference to find the player's collider ****/
    void Start()
    {

        playerRef = GameObject.Find("Player").GetComponent<BoxCollider2D>();
    }
    /**** updates every frame ****/
    void Update()
    {

        /** if the cave is touching the player reference, load the "Level-1-test" scene **/
        if(cave.IsTouching(playerRef))
        {

        	SceneManager.LoadScene("Level-1-test.unity", LoadSceneMode.Additive);
        }
    }
}
