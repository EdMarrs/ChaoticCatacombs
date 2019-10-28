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
    public Transform currentPos;

    public Vector3 rotatePoint = new Vector3(0, 0, 0);
    public Vector3 axis = new Vector3(0, 0, 1);

    private int rotPointX;
    private int rotPointY;

    public float oneX;
    public float oneY;

    public int hp;
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

        hp = gameObject.GetComponent<Enemy>().health;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }

        if (first == false)
        {
            StartCoroutine(A());

            transform.RotateAround(rotatePoint, axis, Time.deltaTime * 400);
            //first = true;
        }
        
        
        if (second == false && first == true)
        {
            StartCoroutine(B());
            //transform.position += new Vector3(oneX * Time.deltaTime, oneY * Time.deltaTime, 0);
            MoveHandsUp();
            ChangeRotPosUp();
            //transform.RotateAround(rotatePoint, axis, Time.deltaTime * 200);
        }
        
        
        if (third == false && second == true)
        {
            StartCoroutine(C());
            transform.RotateAround(rotatePoint, axis, Time.deltaTime * 400);
        }

        
        if (fourth == false && third == true)
        {
            StartCoroutine(D());
            MoveHandsDown();
            ChangeRotPosDown();
            //transform.RotateAround(rotatePoint, axis, Time.deltaTime * 200);
        }

        if (fourth == true)
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

        yield return new WaitForSeconds(5f);
        third = true;

    }
    
    IEnumerator D()
    {
        // keep around 10f
        yield return new WaitForSeconds(1f);
        fourth = true;

    }

    void ResetRotateHand()
    {
        ResetBools();

    }


    // differentiates left and and right hand by rotation direction
    // (left hand rotates left (-1) & right hand rotates right (+1))
    void MoveHandsUp()
    {
        if (axis.z == -1)
        {
            transform.position = new Vector3(2, 1, 0);
            //oneX = -1;
            //oneY = 1;
            //transform.position += new Vector3(oneX * Time.deltaTime * 2, oneY * Time.deltaTime * 2, 0);
        }
        else if (axis.z == 1)
        {
            transform.position = new Vector3(-2, 1, 0);
            //oneX = 1;
            //oneY = 1;
            //transform.position += new Vector3(oneX * Time.deltaTime * 2, oneY * Time.deltaTime * 2, 0);
        }
    }

    void MoveHandsDown()
    {
        if (axis.z == -1)
        {
            transform.position = new Vector3(7, 0, 0);
            //oneX = 1;
            //oneY = -1;
            //transform.position += new Vector3(oneX * Time.deltaTime * 2, oneY * Time.deltaTime * 2, 0);
        }
        else if (axis.z == 1)
        {
            transform.position = new Vector3(-7, 0, 0);
            //oneX = -1;
            //oneY = -1;
           // transform.position += new Vector3(oneX * Time.deltaTime * 2, oneY * Time.deltaTime * 2, 0);
        }
    }

    void ChangeRotPosUp()
    {
        if (axis.z == -1)
        {
            rotatePoint = new Vector3(2, 0, 0);
        }
        else if (axis.z == 1)
        {
            rotatePoint = new Vector3(-2, 0, 0);
        }
    }

    void ChangeRotPosDown()
    {
        if (axis.z == -1)
        {
            rotatePoint = new Vector3(8, -2, 0);
        }
        else if (axis.z == 1)
        {
            rotatePoint = new Vector3(-8, -2, 0);
        }
    }

    void ResetBools()
    {
        first = false;
        second = false;
        third = false;
        //rotationTest = false;
        fourth = false;
        //fifth = false;
    }

    /*
    void StopDoingThings()
    {

        return;
    }
    */
}