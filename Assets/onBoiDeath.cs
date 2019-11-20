﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onBoiDeath : MonoBehaviour
{
    private int hp;


    void Update()
    {
        hp = gameObject.GetComponent<Enemy>().health;
        if (hp <= 0)
        {
            Debug.Log("Killing Enemy");
            //Animation/Transition Here
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);

        }
    }
}
