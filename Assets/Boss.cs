using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Vector3 pos1 = new Vector3(0, 2, 2);
    public Vector3 pos2 = new Vector3(0, 2, 0);
    private int health;
 //   public GameObject blood;
    private Rigidbody2D rb;
    //   public float thrust;

    private bool first = false;
    private bool second = false;
    private bool third = false;
    private bool fourth = false;
    public GameObject winner;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Move from the background into where the player can hit them
        if (Boss1Phase3.lHandDead && Boss1Phase3.rHandDead == true)
        {
            //   transform.position = Vector3.Lerp(pos2, pos1, Time.deltaTime);

            if (first == false)
            {
                StartCoroutine(A());
                BackNForthA();
            }

            if (first == true && second == false)
            {
                StopCoroutine(A());
                StartCoroutine(B());
                BackNForthB();
            }

            if (second == true && third == false)
            {
                StopCoroutine(B());
                StartCoroutine(C());
                BackNForthC();
            }

            if (third == true && fourth == false)
            {
                StopCoroutine(C());
                StartCoroutine(D());
                BackNForthD();
            }

            if (fourth == true)
            {
                ResetBools();
            }


        }



        //Die
        health = gameObject.GetComponent<Enemy>().health;

        if (health <= 0)
        {
            Instantiate(winner);
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
            Destroy(gameObject);
        }

    }

    IEnumerator A()
    {
        Debug.Log("A");
        yield return new WaitForSeconds(1f);
        //   transform.position = Vector3.Lerp(pos2, pos1, Time.deltaTime);
        gameObject.layer = 10;
        first = true;

    }

    IEnumerator B()
    {
        Debug.Log("B");
        yield return new WaitForSeconds(2f);
        second = true;

    }

    IEnumerator C()
    {
        Debug.Log("C");
        yield return new WaitForSeconds(4f);
        third = true;

    }

    IEnumerator D()
    {
        Debug.Log("D");
        yield return new WaitForSeconds(4f);
        fourth = true;

    }



    void BackNForthA()
    {

        transform.position += new Vector3(0, -1 * Time.deltaTime, -1 * Time.deltaTime);

    }
    // 2nd
    void BackNForthB()
    {
        transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);

    }
    // 3rd
    void BackNForthC()
    {
        transform.position += new Vector3(1 * Time.deltaTime, 0, 0);

    }

    //4th
    void BackNForthD()
    {
        transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);

    }

    void ResetBools()
    {
        //   first = false;
        //   second = false;
        third = false;
        fourth = false;
    }


    public void TakeDamage(int damage)
    {
     //   Instantiate(blood, transform.position, Quaternion.identity);
        health -= damage;
        Debug.Log("Damage Taken by Boss");
    }
}
