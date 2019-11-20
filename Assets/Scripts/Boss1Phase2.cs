using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Phase2 : MonoBehaviour
{
    /*
     * This is the script handling the 3rd phase of the Skeleton Boss
     * The hands of the Boss will follow the pattern of moving between 2 points being the platforms
     * After that movement the hands will move in a third motion
     */

    
    public Vector3 origRotPos = new Vector3(0, 0, 0);

    public Vector3 rotatePoint = new Vector3(0, 0, 0);
    public Vector3 axis = new Vector3(0, 0, 1);

    private int rotPointX;
    private int rotPointY;

    public float oneX;
    public float oneY;

    public int hp;
    public float speed;

    public bool whatHand;
    public static bool lHandDead;
    public static bool rHandDead;

    private bool alpha = false;
    private bool first = false;
    private bool second = false;
    private bool third = false;
    private bool fourth = false;
    private bool fifth = false;
    private bool sixth = false;
    private bool seventh = false;

    public float smooth = 2f;
    private Quaternion targetRotationL;
    private Quaternion targetRotationR;



    void Start()
    {
        /* Once player completes phase 2
         * hand health reference will be reset in the Hand Manager
         * will just create new hands instead
         * 
         */

        targetRotationL = transform.rotation;
        targetRotationL *= Quaternion.AngleAxis(0, Vector3.back);
        targetRotationR = transform.rotation;
        targetRotationR *= Quaternion.AngleAxis(0, Vector3.back);

    }

    void Update()
    {
        // currentPos = transform.position;

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

        // moves hands onto screen to start phase of battle
        if (alpha == false)
        {
            StartCoroutine(Alpha());
/*
            if (axis.z == -1)
            {
                transform.position = new Vector3(-7, 12, 0);
            }
            else if (axis.z == 1)
            {
                transform.position = new Vector3(7, 12, 0);
            }
            */
            // move platforms down
            transform.position += new Vector3(0 * Time.deltaTime, -1 * Time.deltaTime, 0);
        }

        // rotate
        if (first == false && alpha == true)
        {
            StartCoroutine(A());
            StopCoroutine(Alpha());
            fourth = false;
            fifth = false;
            sixth = false;
            seventh = false;

            transform.RotateAround(rotatePoint, axis, Time.deltaTime * 300);
           
           
        }

        // reset rotation
        if (second == false && first == true)
        {
            StopCoroutine(A());
            StartCoroutine(B());

            ResetPosition();


           
            //transform.RotateAround(rotatePoint, axis, Time.deltaTime * 200);
        }

        // move up
        if (third == false && second == true)
        {
            StopCoroutine(B());
            StartCoroutine(C());
            MoveHandsUp();
            ChangeRotPosUp();

            
        }

        // rotate
        if (fourth == false && third == true)
        {
            StopCoroutine(C());
            StartCoroutine(D());
            transform.RotateAround(rotatePoint, axis, Time.deltaTime * 300);

            
            //transform.RotateAround(rotatePoint, axis, Time.deltaTime * 200);
        }

        // reset rotation
        if (fifth == false && fourth == true)
        {
            StopCoroutine(D());
            StartCoroutine(E());
                ResetPosition();

        }

        // move down
        if (sixth == false && fifth == true)
        {
            StopCoroutine(E());
            StartCoroutine(F());
            MoveHandsDown();
            ChangeRotPosDown();
        }

        // reset hands positions
        if(seventh == false && sixth == true)
        {
            
            StopCoroutine(F());
            StartCoroutine(G());

            // right hand
            if (axis.z == -1)
            {
           
                  transform.position = new Vector3(7, -1, 0);
            }
            // left hand
            else if (axis.z == 1)
            {
               
                   transform.position = new Vector3(-7, -1, 0);
            }
           
        }
        
        // reset booleans to loop
        if (seventh == true)
        {
            StopCoroutine(G());
            ResetBools();
        }
       

    }

    // starts phase of battle
    IEnumerator Alpha()
    {
        Debug.Log("Alpha");
        yield return new WaitForSeconds(10f);
        alpha = true;

    }

    // rotate
    IEnumerator A()
    {
        Debug.Log("A");
        yield return new WaitForSeconds(6f);
        first = true;

    }
    
    // reset rotation
    IEnumerator B()
    {
        Debug.Log("B");
        yield return new WaitForSeconds(1f);
        second = true;

    }
    // move up
    IEnumerator C()
    {
        Debug.Log("C");
        yield return new WaitForSeconds(2f);
        third = true;

    }
    // rotate
    IEnumerator D()
    {
        Debug.Log("D");
        yield return new WaitForSeconds(6f);
        fourth = true;

    }
     // reset rotation
    IEnumerator E()
    {
        Debug.Log("E");
        yield return new WaitForSeconds(1f);
        fifth = true;

    }
        // move down 
        IEnumerator F()
    {
        Debug.Log("F");
        yield return new WaitForSeconds(2f);
        sixth = true;
      //  seventh = true;

    }

    IEnumerator G()
    {
        Debug.Log("G");
        yield return new WaitForSeconds(2f);
        seventh = true;

    }




    // differentiates left and and right hand by rotation direction
    // (left hand rotates left (-1) & right hand rotates right (+1))
    void MoveHandsUp()
    {
        // right hand
        if (axis.z == -1)
        {
            transform.position += new Vector3(-2 * Time.deltaTime, 1 * Time.deltaTime, 0);

        }
        // left hand
        else if (axis.z == 1)
        {
            transform.position += new Vector3(2 * Time.deltaTime, 1 * Time.deltaTime, 0);

        }
    }

    void MoveHandsDown()
    {
        // right hand
        if (axis.z == -1)
        {
            transform.position += new Vector3(2 * Time.deltaTime, -1 * Time.deltaTime, 0);
            //transform.position = new Vector3(7, -1, 0);

        }
        // left hand
        else if (axis.z == 1)
        {
            transform.position += new Vector3(-2 * Time.deltaTime, -1 * Time.deltaTime, 0);
            //transform.position = new Vector3(-7, -1, 0);

        }
    }

    void ChangeRotPosUp()
    {
        if (axis.z == -1)
        {
            rotatePoint = new Vector3(4, 1, 0);
        }
        else if (axis.z == 1)
        {
            rotatePoint = new Vector3(-4, 1, 0);
        }
    }

    void ChangeRotPosDown()
    {
        if (axis.z == -1)
        {
            rotatePoint = new Vector3(7, -2, 0);
        }
        else if (axis.z == 1)
        {
            rotatePoint = new Vector3(-7, -2, 0);
        }
    }

    void ResetBools()
    {
       
        second = false;
        third = false;
        fourth = false;
        fifth = false;
        sixth = false;
        seventh = false;
        first = false;


    }

    void ResetPosition()
    {
        // right hand
        if (axis.z == -1)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotationR, 10 * smooth * Time.deltaTime);
            //  transform.position = new Vector3(-7, -1, 0);
        }
        // left hand
        else if (axis.z == 1)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotationR, 10 * smooth * Time.deltaTime);
            //   transform.position = new Vector3(7, -1, 0);
        }
    }


}