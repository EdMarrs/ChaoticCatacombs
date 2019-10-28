using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToBossRoom1 : MonoBehaviour
{
    

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerState>().SavePlayer();
            
            SceneManager.LoadScene(2);
        }
    }
}
