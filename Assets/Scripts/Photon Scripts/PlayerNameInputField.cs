using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;

public class PlayerNameInputField : MonoBehaviour
{

    const string playerNamePrefKey = "PlayerName";

    // Start is called before the first frame update
    //Test
    void Start()
    {

        string defaultName = string.Empty;
        InputField _inputField = this.GetComponent<InputField>();

        if (_inputField != null)
        {
            if (PlayerPrefs.HasKey(playerNamePrefKey))
            {
                defaultName = PlayerPrefs.GetString(playerNamePrefKey);
                _inputField.text = defaultName;
            }
        }

        PhotonNetwork.NickName = defaultName;

    }

    public void SetPlayerName(string value)
    {
        // #important
        if (string.IsNullOrEmpty(value))
        {
            Debug.LogError("Player Name is null or empty");
        }
        PhotonNetwork.NickName = value;

        PlayerPrefs.SetString(playerNamePrefKey, value);
    }
}