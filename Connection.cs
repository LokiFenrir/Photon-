using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviourPunCallbacks
{

    //Vars




    //Func

    void Start()
    {

        print("Connecting to server");
        PhotonNetwork.SendRate = 25; // 20
        PhotonNetwork.SerializationRate = 20; //10
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.NickName = "Moh";                                            //Set up Nickname Here
        PhotonNetwork.GameVersion = "0.01";
        PhotonNetwork.ConnectUsingSettings();

    }//Start

    public override void OnConnectedToMaster()
    {

        print("Connected to server");
        if(!PhotonNetwork.InLobby)
            PhotonNetwork.JoinLobby();

    }//OnConnectedToMaster


    public override void OnDisconnected(DisconnectCause cause)
    {

        print("Disconnected from server for reason " + cause.ToString());

    }//OnDisconnected


}// CONNECTION TEST
