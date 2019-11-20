using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressKeyToRestart : MonoBehaviour
{
    
    void Update()
    {
        if (Input.anyKeyDown)
        {

            GlobalControl.Instance.hp = 3;
            GlobalControl.Instance.maxhp = 3;
            GlobalControl.Instance.speed = 5;
            GlobalControl.Instance.jumpforce = 35;
            GlobalControl.Instance.damage = 1;
            GlobalControl.Instance.specialBarCurr = 100;
            GlobalControl.Instance.specialBarMax = 100;

            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}
