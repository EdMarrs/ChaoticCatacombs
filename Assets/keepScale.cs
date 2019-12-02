using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepScale : MonoBehaviour
{
    private bool flipped;
    // Start is called before the first frame update
    void Start()
    {
        flipped = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.parent.transform.localScale.x);
        if (transform.parent.transform.localScale.x < 0 && flipped == false)
        {
            Vector3 temp = transform.localScale;
            temp.x *= -1;
            transform.localScale = temp;
            flipped = true;
        }
        else if (transform.parent.transform.localScale.x > 0 && flipped==true)
        {
            Vector3 temp = transform.localScale;
            temp.x *= -1;
            transform.localScale = temp;
            flipped = false;
        }

    } 
}
