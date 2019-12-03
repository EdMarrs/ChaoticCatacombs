using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class noPlayersExist : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hit 1");
        if (GameObject.Find("Player") != null)
        {
            Debug.Log("Found Something");
            
        }
        else
        {
            Debug.Log("Yeet Outta here");
            PhotonNetwork.Disconnect();
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
