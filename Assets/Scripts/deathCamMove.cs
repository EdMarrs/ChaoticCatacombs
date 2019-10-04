using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathCamMove : MonoBehaviour
{
	public GameObject mainCam;

    // Update is called once per frame
    void Update()
    {
		if (mainCam!=null){
        transform.position = mainCam.transform.position;
		}
    }
}
