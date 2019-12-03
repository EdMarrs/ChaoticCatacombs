using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour
{

	private BoxCollider2D playerRef;
	public BoxCollider2D cave;

    void Start()
    {
        playerRef = GameObject.Find("Player").GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if(cave.IsTouching(playerRef))
        {
        	SceneManager.LoadScene("Level-1-test.unity", LoadSceneMode.Additive);
        }
    }
}
