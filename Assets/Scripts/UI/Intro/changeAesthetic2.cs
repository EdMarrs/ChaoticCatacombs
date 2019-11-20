using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeAesthetic2 : MonoBehaviour
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
    	if (count == 0)
    	{
    		GetComponent<AudioSource>().clip = next;
    		GetComponent<AudioSource>().Play();
    		GetComponent<AudioSource>().loop = true;
    		next = temp;
    	}
    	GetComponent<Image>().sprite = nextPic[count];
    	if (count < nextPic.Length)
    	{
    		count++;
    	}
    }
}
