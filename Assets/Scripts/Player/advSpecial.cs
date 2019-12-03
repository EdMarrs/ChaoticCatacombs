using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advSpecial : MonoBehaviour
{//
    SpriteRenderer sprite;
    public float SpecialBarCurr = 100f;
    public float SpecialBarMax = 100f;
    private bool UsingSpecial = false;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!UsingSpecial)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKeyDown("joystick button 2"))
            {
                if (SpecialBarCurr >= 100)
                {
                    SpecialBarCurr -=100;
                    //activate special
                    UsingSpecial = true;
                    StartCoroutine(ActivatedSpecial());
                }
            }
        }
        else
        {
            //Tried to do special ability and failed
        }
    }

    public IEnumerator ActivatedSpecial()
    {
        Debug.Log("hit special");
        int attackVal = gameObject.GetComponent<whipAttackScript>().damage;
        int normalAttackVal = gameObject.GetComponent<whipAttackScript>().damage;
        Color normalSpriteColor = sprite.color;

        var endTime = Time.time + 10.0f;
        gameObject.GetComponent<whipAttackScript>().damage= attackVal*2;
        sprite.color = new Color(1, 0, 0, 1);

        while (Time.time < endTime)
        {
            
            yield return new WaitForSeconds(0.1f);
        }
        gameObject.GetComponent<whipAttackScript>().damage= normalAttackVal;
        sprite.color = normalSpriteColor;
        Debug.Log("end special");
        UsingSpecial = false;
    }
}
