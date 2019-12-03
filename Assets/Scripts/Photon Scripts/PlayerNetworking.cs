/*This script serves to handle conflicts arising from the issue of both players using one player controller
 * we place our player scripts to be ignored into the array by adding them within the Player Networking component in Unity (drag and drop)
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerNetworking : MonoBehaviour
{
    // this is an array of scripts will will want to ignore when there are two players in the scene
    public MonoBehaviour[] scriptsToIgnore;

    private PhotonView photonView;
    [SerializeField] private GameObject playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();

        // if the current photonView does not belong to me, set each script to disabled for each script within scripts to ignore
        if(!photonView.IsMine)
        {
            foreach (var script in scriptsToIgnore)
            {
                script.enabled = false;
                playerCamera.SetActive(false);
            }
        }

        else
        {
            // enable the player camera if the view is ours
            playerCamera.SetActive(true);
        }

    }

}
