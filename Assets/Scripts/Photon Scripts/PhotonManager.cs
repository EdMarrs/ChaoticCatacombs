using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{

    [SerializeField] private GameObject lobbyCamera;        // create a lobby camera object we can disable upon connecting to the room
    public GameObject player;                               // sets game object of the player


    // Start is called before the first frame update
    void Start()
    {
        
        PhotonNetwork.ConnectUsingSettings();           // connects us to the server
    }
    /**** connects player to master player ****/
    public override void OnConnectedToMaster()
    {

        PhotonNetwork.JoinLobby();          // joins the master's lobby
    }
    /**** when in the lobby, the master creates the room ****/
    public override void OnJoinedLobby()
    {

        // If there is a room available lets join it, if not lets create one
        // sets MaxPlayers to 2 when creating a room
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 2 }, TypedLobby.Default);
    }
    /**** when joined in the room, create the player ****/
    public override void OnJoinedRoom()
    {

        /* Lets create our player
         * 
         * @param PrefabName the method Instantiate() takes a string of the name of the prefab
         * placed withing the Photon Unity Networking Resources folder
         * this prefab is created within the game scene
         * there can be a number of different prefabs within the resources which can be available to us
         * 
         * @param position, we can give a new random vector, or different preset spawn points
         */
        
        PhotonNetwork.Instantiate(player.name, transform.position, Quaternion.identity, 0);
        

        GameObject.Find("Player(MultiplayerVersion)(Clone)").name = "Player";
        Destroy(GameObject.Find("Player Camera"));

        lobbyCamera.SetActive(false);

        PhotonNetwork.InstantiateSceneObject("TheBoiMultiplayer", transform.position, Quaternion.identity, 0, null);


    }
}
