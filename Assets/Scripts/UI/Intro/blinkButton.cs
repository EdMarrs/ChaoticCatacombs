using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blinkButton : MonoBehaviour
{
    
    public Sprite[] next;
    private bool onClick;
    // Start is called before the first frame update
    public IEnumerator blink()
    {
    	onClick = false;
    	while (!onClick)
    	{
	    	GetComponent<Image>().sprite = next[1];
	    	for (int i = 0; i < 35; i++)
	    	{
	    		yield return null;
	    	}
	    	GetComponent<Image>().sprite = next[2];
	    	for (int i = 0; i < 35; i++)
	    	{
	    		yield return null;
	    	}
	    	GetComponent<Image>().sprite = next[3];
	    	for (int i = 0; i < 35; i++)
	    	{
	    		yield return null;
	    	}
	    	GetComponent<Image>().sprite = next[2];
	    	for (int i = 0; i < 35; i++)
	    	{
	    		yield return null;
	    	}
    	}
    }

    public void hide()
    {
    	onClick = true;
    	GetComponent<Image>().sprite = next[0];
    }
}