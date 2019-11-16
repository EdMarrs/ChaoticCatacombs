using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class printDialog : MonoBehaviour
{
    private Queue<string> lines;
    public Text dialogText;

    // Start is called before the first frame update
    void Start()
    {
        lines = new Queue<string>();
        FindObjectOfType<dialogTrigger>().triggerDialog();
    }

    public void StartDialog(Dialog dialog)
    {
    	lines.Clear();
    	foreach (string line in dialog.lines)
    	{
    		lines.Enqueue(line);
    	}

    	DisplayNextLine();
    }

    public void DisplayNextLine()
    {
    	FindObjectOfType<blinkButton>().hide();
        if (lines.Count == 0)
    	{
    		end();
    		return;
    	}
    	StopAllCoroutines();
    	StartCoroutine(type(lines.Dequeue()));
    }

    IEnumerator type(string sentence)
    {
        if(lines.Count == 9)
        {
            FindObjectOfType<changeAesth>().swap();
        }

        else if(lines.Count == 5)
        {
            FindObjectOfType<changeAesth>().swap();
        }

        else if (lines.Count == 1)
        {
            FindObjectOfType<changeAesth>().swap();
        }

        dialogText.text = "";
    	foreach (char letter in sentence.ToCharArray())
    	{
    		dialogText.text += letter;
    		for (int i = 0; i < 5; i++)
    			yield return null;
    	}
        if (lines.Count == 10)
        {
            FindObjectOfType<changeAesth>().swap();
            for (int i = 0; i < 60; i++)
                yield return null;
            FindObjectOfType<changeAesth>().swap();
        }
        StartCoroutine(FindObjectOfType<blinkButton>().blink());
    }

    public void end()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}