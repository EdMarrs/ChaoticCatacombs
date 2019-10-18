using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    public void triggerDialog()
    {
    	FindObjectOfType<printDialog>().StartDialog(dialog);
    }
}
