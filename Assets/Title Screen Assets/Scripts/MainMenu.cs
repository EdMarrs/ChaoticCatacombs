using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayMultiplayer()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Debug.Log("The Game Has Quit");
        Application.Quit();
    }
}

