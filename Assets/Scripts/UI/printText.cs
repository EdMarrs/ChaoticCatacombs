using System;
using UnityEngine;
using UnityEngine.UI;


//Known issues:
//	Text will stutter display between each line
//	Animations are not behind text
//	Text file containing lines to display not linked
//	Must test with different sized lines
//	Must determine how many lines for intro

public class printText : MonoBehaviour
{
    private float timer;
    private float delay;
    private float readDelay;
    protected string startString, currentStatement;
    private char[] letters;
    private int i;
    private int j;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        delay = 0.15f;
        readDelay = 100.0f;
        currentStatement = "";
        startString = "This is story text";
        letters = startString.ToCharArray();
        i = 0;
        j = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delay)
        {
        	timer = 0.0f;
        	if (i != letters.Length)
        	{
        		currentStatement += letters[i];
        		GetComponent<Text>().text = currentStatement;
        		i++;
        	}
        	else
        		Invoke("read", 5f);
        }
    }

    //Allows the full line to be read for a short while
    void read()
    {
        GetComponent<Text>().text = currentStatement;
        currentStatement = "";
        i = 0;
    }

    // void swap() {} //will swap lines to display to the player
    //startString = nextLine[++j];
        //Determines when intro scene is over
        // if (j == nextLine.Length - 1)
        // {
        // 	Put transition to start screen scene here
        // }
}