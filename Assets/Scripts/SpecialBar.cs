using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBar : MonoBehaviour
{
    private Transform bar;
    private float SpecialBarCurr;
    
    void Start()
    {
        bar = transform.Find("Bar");
        
       
    }

    
    void Update()
    {

        SpecialBarCurr = GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarCurr;
        
        bar.localScale = new Vector3((SpecialBarCurr / 100f), 1f);
    }
}
