using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogTrigger2 : MonoBehaviour
{
   public Dialog dialog;

    public void triggerDialog()
    {
    	FindObjectOfType<printDialogEnd>().StartDialog(dialog);
    }
}
