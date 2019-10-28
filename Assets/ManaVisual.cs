using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaVisual : MonoBehaviour
{
    // Start is called before the first frame update
    public Text mana;
    void Start()
    {
        mana = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        mana.text = GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarCurr + "/" + GameObject.Find("Player").GetComponent<advSpecial>().SpecialBarMax;
        
    }
}
