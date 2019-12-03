using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**** Takes care of Scene Management in the Main Menu ****/
public class TitleScreen : MonoBehaviour
{

    /*** Plays game upon hitting "Start" button ***/
    public void play()
    {
        // finds next scene's index by the build
        // File -> Build Settings -> "Scenes in Build"
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /*** Quits game upon hitting "Quit" button ***/
    public void quit()
    {

        Debug.Log("Quit");
        Application.Quit();
    }
}
