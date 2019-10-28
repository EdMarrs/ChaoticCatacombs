using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Phase1 : MonoBehaviour
{

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
    private bool fourth = false;
    private bool fifth = false;

    private bool sixth = false;
    private bool seventh = false;
    private bool eighth = false;
    private bool ninth = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hp = gameObject.GetComponent<Enemy>().health;

        if (whatHand == true)
        {
            if (hp <= 0)
            {
                lHandDead = true;
                Destroy(gameObject);
            }
        }
        if (whatHand == false)
        {
            if (hp <= 0)
            {
                rHandDead = true;
                Destroy(gameObject);
            }
        }


        // Beginning of boolean values & if statements to mangage IEnumerators

        // move up
        if (first == false)
        {
            StartCoroutine(A());
            MoveUpA();
        }

        // shift direction
        if (second == false && first == true)
        {
            StopCoroutine(A());
            StartCoroutine(B());
            ShiftDirectionA();
        }

        // pause
        if (third == false && second == true)
        {
            StopCoroutine(B());
            StartCoroutine(C());
        }

        // slam down
        if (fourth == false && third == true)
        {
            StopCoroutine(C());
            StartCoroutine(D());
            SlamDownA();
        }

        // move up
        if (fifth == false && fourth == true)
        {
            StopCoroutine(D());
            StartCoroutine(E());
            MoveUpB();
        }

        // shift direction
        if (sixth == false && fifth == true)
        {
            StopCoroutine(E());
            StartCoroutine(F());
            ShiftDirectionB();
        }

        // pause
        if (seventh == false && sixth == true)
        {
            StopCoroutine(F());
            StartCoroutine(G());
     
        }

        // slam down
        if (eighth == false && seventh == true)
        {
            StopCoroutine(G());
            StartCoroutine(H());
            SlamDownB();
        }

        // reset loop
        if(eighth == true)
        {
            ResetBools();
        }


        // timers that act as delays for running functions

        // move up
        IEnumerator A()
        {
            Debug.Log("A");
            yield return new WaitForSeconds(1f);
            first = true;

        }

        // shift direction
        IEnumerator B()
        {
            Debug.Log("B");
            yield return new WaitForSeconds(1f);
            second = true;

        }

        // pause
        IEnumerator C()
        {
            Debug.Log("C");
            yield return new WaitForSeconds(1f);
            third = true;

        }

        // slam down
        IEnumerator D()
        {
            Debug.Log("D");
            yield return new WaitForSeconds(1f);
            fourth = true;

        }

        // move up
        IEnumerator E()
        {
            Debug.Log("E");
            yield return new WaitForSeconds(1f);
            fifth = true;

        }

        // shift direction
        IEnumerator F()
        {
            Debug.Log("F");
            yield return new WaitForSeconds(1f);
            sixth = true;

        }

        // pause
        IEnumerator G()
        {
            Debug.Log("G");
            yield return new WaitForSeconds(1f);
            seventh = true;

        }

        // slam down
        IEnumerator H()
        {
            Debug.Log("H");
            yield return new WaitForSeconds(1f);
            eighth = true;

        }

        void MoveUpA()
        {
            transform.position += new Vector3(oneX * Time.deltaTime, oneY * Time.deltaTime, 0);
        }

        void ShiftDirectionA()
        {
            transform.position += new Vector3(twoX * Time.deltaTime, twoY * Time.deltaTime, 0);
        }

        // pause with IEnumerator

        void SlamDownA()
        {
            transform.position += new Vector3(threeX * Time.deltaTime, threeY * Time.deltaTime, 0);
        }

        void MoveUpB()
        {
            transform.position += new Vector3(fourX * Time.deltaTime, fourY * Time.deltaTime, 0);
        }

        void ShiftDirectionB()
        {
            transform.position += new Vector3(fiveX * Time.deltaTime, fiveY * Time.deltaTime, 0);
        }

        // pause with IEnumerator

        void SlamDownB()
        {
            transform.position += new Vector3(sixX * Time.deltaTime, sixY * Time.deltaTime, 0);
        }

        void ResetBools()
        {
            first = false;
            second = false;
            third = false;
            fourth = false;
            fifth = false;
            sixth = false;
            seventh = false;
            eighth = false;
        }




        }
}
