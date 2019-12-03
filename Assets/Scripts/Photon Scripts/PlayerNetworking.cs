/* This script serves to handle conflicts arising from the issue of both players using one player controller
 * we place our player scripts to be ignored into the array by adding them within the Player Networking component in Unity (drag and drop)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerNetworking : MonoBehaviour
{

    public MonoBehaviour[] scriptsToIgnore;     // this is an array of scripts will will want to ignore when there are two players in the scene

    private PhotonView photonView;              // identifies the object on the network to be configured
    [SerializeField] private GameObject playerCamera;       // camera for the player
    

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();        // gets the view from Photon

        /*** if the current photonView does not belong to me, set each script to disabled for each script within scripts to ignore
         * else if, enable the player camera
        ***/
        if(!photonView.IsMine)
        {

            /*** for each script in scriptsToIgnore, disable the script and decativate the player camera ***/
            foreach (var script in scriptsToIgnore)
            {

                script.enabled = false;
                playerCamera.SetActive(false);
            }
        }
        else
        {
            
            playerCamera.SetActive(true);           // enable the player camera if the view is ours
        }

    }

}
