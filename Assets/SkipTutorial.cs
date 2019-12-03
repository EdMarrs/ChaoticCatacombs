using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipTutorial : MonoBehaviour
{

    void Update()
    {
        // skips tutorial room and goes straight into the main level
        if (Input.GetKeyDown("s"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
