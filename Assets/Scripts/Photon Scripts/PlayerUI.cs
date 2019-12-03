using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

using System.Collections;

public class PlayerUI : MonoBehaviour
{//

    private PlayerNetworking target;

    [Tooltip("UI Text to display Player's Name")]
    [SerializeField] private Text playerNameText;

    public void setTarget(PlayerNetworking _target)
    {

        if ( _target == null)
        {
            Debug.LogError("<Color=Red><a>Missing</a></Color> PlayMakerManager target for PlayerUI.SetTarget.", this);
            return;
        }

        target = _target;
        if (playerNameText != null)
        {
            playerNameText.text = target.GetComponent<PhotonView>().Owner.NickName;
        }
    }
}
