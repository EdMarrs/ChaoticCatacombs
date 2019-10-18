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
    private float timer, delay;
    protected string startString, currentString;
    private char[] letters;
    private int i;
    private int j;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        delay = 0.15f;
        currentString = "";
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
        		currentString += letters[i];
        		GetComponent<Text>().text = currentString;
        		i++;
        	}
        	else
        		Invoke("read", .61999999f);
        }
    }

    //Allows the full line to be read for a short while
    void read()
    {
        GetComponent<Text>().text = currentString;
        currentString = "";
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