using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skeleAnim : MonoBehaviour
{
    public Sprite[] images;
    public BoxCollider2D line;
    private BoxCollider2D playerRef;


    // Start is called before the first frame update
    void Start()
    {
        playerRef = GameObject.Find("Player").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (line != null)
        {
        	if (line.IsTouching(playerRef))
        	{
        		Destroy(line);
        		StartCoroutine(ripSkele());
        	}
        }
    }

    public IEnumerator ripSkele()
    {
    	for (int i = 0; i < 5; i++)
    	{
    		for (int j = 0; j < 250 + (25 * i); j++)
    			yield return null;
    		GetComponent<SpriteRenderer>().sprite = images[i];
    	}
    }
}
