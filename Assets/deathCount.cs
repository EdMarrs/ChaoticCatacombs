using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class deathCount : MonoBehaviour
{
    public int currDeathCount;
    public int numOfPlayers;

    // Update is called once per frame
    void Start()
    {
        currDeathCount = 0;
    }
    void Update()
    {
        numOfPlayers = PhotonNetwork.CountOfPlayers;
        if (currDeathCount == PhotonNetwork.CountOfPlayers)
        {
            
        }
    }
}
