using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class LeaveGame : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void leaveGame()
    {
        PhotonNetwork.Disconnect();


        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
