using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Phase3 : MonoBehaviour
{
    /*
     * This is the script handling the 3rd phase of the Skeleton Boss
     * The hands of the Boss will follow the pattern of moving between 2 points being the platforms
     * After that movement the hands will move in a third motion
     */

    public Vector3 pos1 = new Vector3(0, 0, 0);
    public Vector3 pos2 = new Vector3(0, 0, 0);
    public Vector3 newPos1 = new Vector3(0, 0, 0);
    public Vector3 newPos2 = new Vector3(0, 0, 0);
    public Vector3 clapPos1 = new Vector3(0, 0, 0);
    public Vector3 clapPos2 = new Vector3(0, 0, 0);
    public Vector3 rotPos = new Vector3(0, 0, 0);
    public Vector3 origRotPos = new Vector3(0, 0, 0);
    public Transform currentPos;
    

    public float speed;
    
    private bool first = false;
    private bool second = false;
    private bool third = false;
    private bool rotationTest = false;
    private bool fourth = false;
    private bool fifth = false;



    void Start()
    {
        /* Once player completes phase 2
         * hand health reference will be reset in the Hand Manager
         * 
         * 
         */


        
        
    }

    void Update()
    {
       // currentPos = transform.position;

        if (first == false)
        {
            StartCoroutine(A());
            BackNForth();
        }

        if (second == false && first == true)
        {

            if (rotationTest == false)
            {
                RotateHand();
            }

            StartCoroutine(B());
     
        }

        if ( third == false && first == true)
        {
            
            StartCoroutine(C());
            MoveToClap();
        }

        if (fourth == false && third == true)
        {
            StartCoroutine(D());
            ClapHands();
            
        }

        if (fifth == false && fourth == true)
        {
            StartCoroutine(E());
            FinalMovement();
        }

        if(first && second && third && fourth && fifth == true)
        {
            ResetRotateHand();
           
           
        }
        /*
        print("test: " + test);
        print("first: " + first);
        print("third: " + third);
        print("fourth: " + fourth);
        print("rotationTest: " + rotationTest);

        */
    }


    // These are a bit Unreliable, they don't always start at the same time, causing issues... 

    IEnumerator A()
    {
      
        yield return new WaitForSeconds(5f);
        first = true;

    }

    IEnumerator B()
    {

        yield return new WaitForSeconds(1f);
        second = true;

    }

    IEnumerator C()
    {

        yield return new WaitForSeconds(1f);
        third = true;

    }

    IEnumerator D()
    {
        // keep around 10f
        yield return new WaitForSeconds(5f);
        fourth = true;
 
    }

    IEnumerator E()
    {
        
        yield return new WaitForSeconds(1f);
        fifth = true;

    }

    void BackNForth()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        fourth = false;
        fifth = false;
    }

    void RotateHand()
    {
        transform.Rotate(rotPos);
        rotationTest = true;
    }

    void ResetRotateHand()
    {
        transform.Rotate(origRotPos);
        ResetBools();

    }

    void MoveToClap()
    {
        transform.position = Vector3.Lerp(newPos1, newPos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }

    void ClapHands()
    {
        transform.position = Vector3.Lerp(clapPos1, clapPos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }

    void FinalMovement()
    {
        transform.position = Vector3.Lerp(pos2, clapPos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }

    void ResetBools()
    {
        first = false;
        second = false;
        third = false;
        rotationTest = false;
        fourth = false;
        fifth = false;
    }

    /*
    void StopDoingThings()
    {

        return;
    }
    */
}
