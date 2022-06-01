using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConnectToServer : MonoBehaviourPunCallbacks
{

    public InputField playernameInput;
    public Text buttontext;

    public void OnClickConnect()
    {
        if (playernameInput.text.Length >= 1)
        {
            PhotonNetwork.NickName = playernameInput.text;
            buttontext.text = "connecting";
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
