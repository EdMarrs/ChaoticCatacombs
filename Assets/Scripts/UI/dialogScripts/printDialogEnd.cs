using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class printDialogEnd : MonoBehaviour
{
    private Queue<string> lines;
    public Text dialogText;

    // Start is called before the first frame update
    void Start()
    {
        lines = new Queue<string>();
        FindObjectOfType<dialogTrigger2>().triggerDialog();
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
            FindObjectOfType<changeAesthetic2>().swap();
        }

        else if(lines.Count == 3)
        {
            FindObjectOfType<changeAesthetic2>().swap();
        }
        dialogText.text = "";
    	foreach (char letter in sentence.ToCharArray())
    	{
    		dialogText.text += letter;
    		for (int i = 0; i < 7; i++)
    			yield return null;
    	}
        if (lines.Count == 0)
        {
            FindObjectOfType<changeAesthetic2>().swap();
            for (int i = 0; i < 60; i++)
                yield return null;
            FindObjectOfType<changeAesthetic2>().swap();
        }
        StartCoroutine(FindObjectOfType<blinkButton>().blink());
    }

    public void end()
    {
        //Sends the player back to the main menu
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
