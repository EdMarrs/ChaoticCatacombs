using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOffscreen : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
