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
    	dialogText.text = lines.Dequeue();
    	 
    }

    public void end()
    {
    	//end dialog here
    }
}
