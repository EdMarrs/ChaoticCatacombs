using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeAesth : MonoBehaviour
{
    public AudioClip next;
    public Sprite[] nextPic;
    private AudioClip temp;
    private int count;

    void Start()
    {
    	count = 0;
    	temp = GetComponent<AudioSource>().clip;
    }

    public void swap()
    {
    	if (count >= 3)
    	{
    		GetComponent<AudioSource>().clip = next;
    		GetComponent<AudioSource>().Play();
    		GetComponent<AudioSource>().loop = true;
    		next = temp;
    	}
    	else if (count == 2)
    	{
    		GetComponent<RectTransform>().sizeDelta += new Vector2(2, 1);
    	}
    	GetComponent<Image>().sprite = nextPic[count];
    	if (count < nextPic.Length)
    	{
    		count++;
    	}
    }
}