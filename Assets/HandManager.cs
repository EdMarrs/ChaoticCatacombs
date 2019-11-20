using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{

    private bool phase1;
    private bool phase2 = true;
    private bool phase3 = true;

    private bool lHandDead1;
    private bool rHandDead1;
    private bool lHandDead2;
    private bool rHandDead2;
    private bool lHandDead3;
    private bool rHandDead3;
    private bool test = true;

    public GameObject p1HandL;
    public GameObject p1HandR;

    public GameObject p2HandL;
    public GameObject p2HandR;

    public GameObject p3HandL;
    public GameObject p3HandR;


    void Start()
    {
          Instantiate(p1HandL);
          Instantiate(p1HandR);
    }


    void Update()
    {
        rHandDead1 = Boss1Phase1.rHandDead;
        lHandDead1 = Boss1Phase1.lHandDead;
        rHandDead2 = Boss1Phase2.rHandDead;
        lHandDead2 = Boss1Phase2.lHandDead;
        rHandDead3 = Boss1Phase3.rHandDead;
        lHandDead3 = Boss1Phase3.lHandDead;


        if (rHandDead1 && lHandDead1 && phase2 == true)
        {
            Instantiate(p2HandL);
            Instantiate(p2HandR);
            phase2 = false;

        }

        if (rHandDead2 && lHandDead2 && phase3 == true)
        {
            Instantiate(p3HandL);
            Instantiate(p3HandR);
            phase3 = false;
           
        }
       
    }
}
