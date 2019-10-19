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
    	dialogText.text = "";
    	foreach (char letter in sentence.ToCharArray())
    	{
    		dialogText.text += letter;
    		for (int i = 0; i < 5; i++)
    			yield return null;
    	}
    }

    public void end()
    {
    	//Shift to next scene
    }
}
