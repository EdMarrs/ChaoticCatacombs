using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Phase3 : MonoBehaviour
{
    /*
     * This is the script handling the 3rd phase of the Skeleton Boss
     * The hands of the Boss will follow the pattern of moving between 2 points being the platforms
     * After that movement the hands will move in a clapping motion
     */

    public Vector3 pos1 = new Vector3(0, 0, 0);
    public Vector3 pos2 = new Vector3(0, 0, 0);
    public float speed;



    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
