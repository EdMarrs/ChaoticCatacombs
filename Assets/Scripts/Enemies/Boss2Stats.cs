using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Stats : MonoBehaviour
{ 
	public int phase=1;

    void Update()
    {
        if (gameObject.GetComponent<Enemy>().health <= 1)
        {
            phase = 3;
        }
        else if (gameObject.GetComponent<Enemy>().health <= 5)
        {
            phase = 2;
        }
    }
}
