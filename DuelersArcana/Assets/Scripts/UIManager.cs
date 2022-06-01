using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class UIManager : MonoBehaviour
{


    public TMP_Text playername;
    public TMP_Text opponentname;
    public TMP_Text playerDeckCount;
    public TMP_Text opponentDeckCount;

    public TMP_Text playerActions;
    public TMP_Text playerMP;

    public TMP_Text opponentActions;
    public TMP_Text opponentMP;

    public PhotonView photonview;
    // Start is called before the first frame update
    private void Awake()
    {
        playername.text = PhotonNetwork.LocalPlayer.NickName;
    }

    void Start()
    {
        updateOpponentsNickName();
    }

    void updateOpponentsNickName()
    {
        photonview.RPC("SyncNames", RpcTarget.OthersBuffered, playername.text);
    }

    public void updateOpponentsDeckCount(int count)
    {
        photonview.RPC("SyncDeckCounts", RpcTarget.OthersBuffered, count);
    }

    public void updateMP(int mp)
    {
        playerMP.text = mp.ToString();
        photonview.RPC("SyncMP", RpcTarget.OthersBuffered, mp);
    }
    public void updateActions(int actions)
    {
        playerActions.text = actions.ToString();
        photonview.RPC("SyncActions", RpcTarget.OthersBuffered, actions);
    }

    [PunRPC]
    void SyncNames(string name)
    {
        opponentname.text = name;
    }
    [PunRPC]
    void SyncDeckCounts(int count)
    {
        opponentDeckCount.text = count.ToString();
    }
    [PunRPC]
    void SyncMP(int mp)
    {
        opponentMP.text = mp.ToString();
    }
    [PunRPC]
    void SyncActions(int actions)
    {
        opponentActions.text = actions.ToString();
    }
}