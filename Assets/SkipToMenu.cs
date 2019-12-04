using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SkipToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            

            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}
