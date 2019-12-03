using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;           // instance of this class

    public int hp;                                  // set for health points
    public int maxhp;                               // set for max health points
    public float speed;                             // set for speed
    public float jumpforce;                         // set for amount of jump
    public int damage;                              // set for damage
    public float specialBarCurr;                    // set for the current bar
    public float specialBarMax;                     // set for the max bar


    /**** on load, checks instance ****/
    void Awake()
    {

        /** if the instance is null, don't destroy the game object, set to this
         * else if the instance is not null, destroy the game object
        **/
        if (Instance == null)
        {

            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {

            Destroy(gameObject);
        }
    }
}
