using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class getName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = transform.parent.gameObject.GetComponent<PhotonView>().Owner.NickName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
