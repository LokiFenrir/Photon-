using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomListing : MonoBehaviour
{

    //Vars

    [SerializeField]
    Text _text;

    public RoomInfo _roomInfo { get; private set; }


    //Func


    public void SetRoomInfo(RoomInfo roomInfo)
    {

        _roomInfo = roomInfo;
        _text.text = roomInfo.MaxPlayers + ", " + roomInfo.Name;

    }//SetRoomInfor


    public void JoinRoom()
    {

        PhotonNetwork.JoinRoom(_roomInfo.Name);

    }//JoinRoom


}// ROOM LISTING
