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


    public float oneX;
    public float oneY;

    public float twoX;
    public float twoY;

    public float threeX;
    public float threeY;

    public float fourX;
    public float fourY;

    public float fiveX;
    public float fiveY;

    public float sixX;
    public float sixY;

    public int hp;
    public float speed;

    public bool whatHand;

    public static bool lHandDead;
    public static bool rHandDead;

    private bool first = false;
    private bool second = false;
    private bool third = false;
    private bool rotationTest = false;
    private bool fourth = false;
    private bool fifth = false;

    private bool sixth = false;
    private bool seventh = false;
    private bool eighth = false;
    private bool ninth = false;
    private bool tenth = false;
    private bool eleventh = false;
    private bool twelfth = false;
    private bool thirteenth = false;

    public float smooth = 2f;
    private Quaternion targetRotationL;
    private Quaternion targetRotationR;
    private Quaternion resetRotation;


    void Start()
    {
        /* Once player completes phase 2
         * hand health reference will be reset in the Hand Manager
         * 
         * 
         */

        targetRotationL = transform.rotation;
        targetRotationL *= Quaternion.AngleAxis(90, Vector3.back);
        targetRotationR = transform.rotation;
        targetRotationR *= Quaternion.AngleAxis(-90, Vector3.back);
        resetRotation = transform.rotation;
        resetRotation *= Quaternion.AngleAxis(0, Vector3.back);


    }

    void Update()
    {
      //   currentPos = gameObject.transform.position;
        // set current position between each function is called, so its the hands last position
       // then move the hands from the current posititon to its new start position

        hp = gameObject.GetComponent<Enemy>().health;

        if (whatHand == true)
        {
            if (hp <= 0)
            {
                lHandDead = true;
                Destroy(gameObject);
            }
        }
        if (whatHand == false) {
            if (hp <= 0)
            {
                rHandDead = true;
                Destroy(gameObject);
            }
        }



        // Beginning of boolean values & if statements to mangage IEnumerators

        if (first == false)
        {
            StartCoroutine(A());
            BackNForthA();
        }

        if (second == false && first == true)
        {
            StopCoroutine(A());
            StartCoroutine(B());
            BackNForthB();
        }

        if ( third == false && second == true)
        {
            StopCoroutine(B());
            StartCoroutine(C());
            BackNForthC();
            // MoveToClap();
        }

        if (fourth == false && third == true)
        {
            StopCoroutine(C());
            StartCoroutine(D());
            BackNForthD();
            //   ClapHands();

        }

        if (fifth == false && fourth == true)
        {
            StopCoroutine(D());
            StartCoroutine(E());

      
                RotateHand();
           
           
        }

        if (sixth == false && fifth == true)
        {
            StopCoroutine(E());
            StartCoroutine(F());
            MoveToClap();
        }

        if (seventh == false && sixth == true)
        {
            StopCoroutine(F());
            StartCoroutine(G());
            ShakeA();
        }

        if (eighth == false && seventh == true)
        {
            StopCoroutine(G());
            StartCoroutine(H());
            ShakeB();
        }

        if (ninth == false && eighth == true)
        {
            StopCoroutine(H());
            StartCoroutine(I());
            ShakeC();
        }

        if (tenth == false && ninth == true)
        {
            StopCoroutine(I());
            StartCoroutine(J());
            ShakeD();
        }

        if (eleventh == false && tenth == true)
        {
            StopCoroutine(J());
            StartCoroutine(K());
            ClapHands();
        }

        if (twelfth == false && eleventh == true)
        {
            StopCoroutine(K());
            StartCoroutine(L());
            ResetRotateHand();
        }

        if (thirteenth == false && twelfth == true)
        {
            StopCoroutine(L());
            StartCoroutine(M());
            FinalMovement();
        }

        // final one if everything is true
        if (thirteenth == true)
        {
            StopCoroutine(M());
            ResetBools();   
        }

    }


   
    // timers that act as delays for running functions

    IEnumerator A()
    {
        Debug.Log("A");
        yield return new WaitForSeconds(1f);
        first = true;

    }

    IEnumerator B()
    {
        Debug.Log("B");
        yield return new WaitForSeconds(1f);
        second = true;

    }

    IEnumerator C()
    {
        Debug.Log("C");
        yield return new WaitForSeconds(1f);
        third = true;

    }

    IEnumerator D()
    {
        Debug.Log("D");
        yield return new WaitForSeconds(1f);
        fourth = true;
 
    }

    IEnumerator E()
    {
        Debug.Log("E");
        yield return new WaitForSeconds(1f);
        fifth = true;

    }

    // MoveToClap()
    IEnumerator F()
    {
        Debug.Log("F");
        yield return new WaitForSeconds(0.8f);
        sixth = true;

    }

    IEnumerator G()
    {
        Debug.Log("G");
        yield return new WaitForSeconds(1f);
        seventh = true;

    }

    IEnumerator H()
    {
        Debug.Log("H");
        yield return new WaitForSeconds(1f);
        eighth = true;

    }

    IEnumerator I()
    {
        Debug.Log("I");
        yield return new WaitForSeconds(1f);
        ninth = true;

    }

    IEnumerator J()
    {
        Debug.Log("J");
        yield return new WaitForSeconds(1f);
        tenth = true;

    }
    // HandClap()
    IEnumerator K()
    {
        Debug.Log("K");
        yield return new WaitForSeconds(1.412f);
        eleventh = true;

    }

   // reset rotation
    IEnumerator L()
    {
        Debug.Log("L");
        yield return new WaitForSeconds(1f);
        twelfth = true;

    }
    // FinalMovement()
    IEnumerator M()
    {
        Debug.Log("M");
        yield return new WaitForSeconds(1.2f);
        thirteenth = true;

    }
    // 1st
    void BackNForthA()
    {
        //   transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        transform.position += new Vector3(oneX * Time.deltaTime, oneY * Time.deltaTime, 0);

    }
    // 2nd
    void BackNForthB()
    {     
        transform.position += new Vector3(-oneX * Time.deltaTime, -oneY * Time.deltaTime, 0);
       
    }
    // 3rd
    void BackNForthC()
    {
        transform.position += new Vector3(oneX * Time.deltaTime, oneY * Time.deltaTime, 0);
       
    }
    // 4th
    void BackNForthD()
    {
        transform.position += new Vector3(-oneX * Time.deltaTime, -oneY * Time.deltaTime, 0);
        
    }
    // 5th
    void RotateHand()
    {

        if (whatHand == true)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotationL, 10 * smooth * Time.deltaTime);
        }

        if (whatHand == false)
        {

            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotationR, 10 * smooth * Time.deltaTime);
        }
    }
    // 12th
    void ResetRotateHand()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, resetRotation, 10 * smooth * Time.deltaTime);


    }
    // 6th
    void MoveToClap()
    {
        // transform.position = Vector3.Lerp(clapPos1, newPos2, Mathf.PingPong(Time.time * speed, 1.0f));
        transform.position += new Vector3(-twoX * Time.deltaTime, -twoY * Time.deltaTime, 0);
    }

    // 7th
    void ShakeA()
    {
        transform.position += new Vector3(threeX * Time.deltaTime /4, 0, 0);
    }
    // 8th
    void ShakeB()
    {
        transform.position += new Vector3(-threeX * Time.deltaTime / 4, 0, 0);
    }
    // 9th
    void ShakeC()
    {
        transform.position += new Vector3(threeX * Time.deltaTime / 4, 0, 0);
    }
    // 10th
    void ShakeD()
    {
        transform.position += new Vector3(-threeX * Time.deltaTime / 4, 0, 0);
    }


    // 11th
    void ClapHands()
    {
        //   transform.position = Vector3.Lerp(clapPos2, clapPos1, Mathf.PingPong(Time.time * speed/2, 1.0f));
        transform.position += new Vector3(fourX * Time.deltaTime, 0, 0);
    }
    // 13th
    void FinalMovement()
    {
        transform.position += new Vector3(-fiveX * Time.deltaTime, fiveY * Time.deltaTime, 0);

        // transform.position = Vector3.Lerp(pos1, clapPos2, Mathf.PingPong(Time.time * speed / 2, 1.0f));
    
    }

    void ResetBools()
    {
        first = false;
        second = false;
        third = false;
        rotationTest = false;
        fourth = false;
        fifth = false;
        sixth = false;
        seventh = false;
        eighth = false;
        ninth = false;
        tenth = false;
        eleventh = false;
        twelfth = false;
        thirteenth = false;
}

    /*
    void StopDoingThings()
    {

        return;
    }
    */
}
