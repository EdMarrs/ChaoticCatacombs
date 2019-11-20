using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFlipping : MonoBehaviour
{
   
    void Start()
    {
     
    }
    void Update()
    {
        float playerPos = GameObject.Find("Player").GetComponent<Transform>().position.x;
        float batPos = GetComponent<Transform>().position.x;
        float side = playerPos - batPos;
        if (side >= 0)
        {
            GetComponent<SpriteRenderer>().flipX =true;
        }
        else if (side< 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
