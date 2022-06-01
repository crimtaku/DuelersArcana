using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public InputField roomname;
    public GameObject mainpanel;
    public GameObject searchingpanel;


    // Start is called before the first frame update
    public void CreateRoom()
    {
        RoomOptions roomoptions = new RoomOptions()
        {
            IsOpen = true,
            IsVisible = false,
            MaxPlayers = 2
        };
        PhotonNetwork.CreateRoom(roomname.text, roomoptions);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(roomname.text);
    }

    public void CancelSearch()
    {
        PhotonNetwork.LeaveRoom();
        searchingpanel.SetActive(false);
        mainpanel.SetActive(true);
    }

    public override void OnJoinedRoom()
    {
        searchingpanel.SetActive(true);
        mainpanel.SetActive(false);

        Debug.Log("joined a room, players in room: " + PhotonNetwork.CurrentRoom.PlayerCount + "/2");
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            Debug.Log("room full, loading game");
            PhotonNetwork.LoadLevel("Game");
        }
    }

    public void FindMatch()
    {
        RoomOptions roomoptions = new RoomOptions()
        {
            IsOpen = true,
            IsVisible = true,
            MaxPlayers = 2
        };
        //PhotonNetwork.JoinRoom("Random match room");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("Another player joined, players in room: " + PhotonNetwork.CurrentRoom.PlayerCount + "/2");
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            Debug.Log("room full, loading game");
            PhotonNetwork.LoadLevel("Game");
        }
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        
    }
}
