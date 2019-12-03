using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialToggleMiniMap : MonoBehaviour
{
    public static bool isFound;


    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    void Update()
    {

        // turns on mini map in tutorial room
        if (isFound == true)
        {
            transform.localScale = new Vector3(1, 1, 0);   
        }


    }
}
