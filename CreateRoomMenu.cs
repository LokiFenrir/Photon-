using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

 public class CreateRoomMenu : MonoBehaviourPunCallbacks
 {

        //Vars

        [SerializeField]
        Text _roomName;

        MenuCanvas _menuCanvas;


        //Func


        public void FirstInitialised(MenuCanvas menu)
        {

            _menuCanvas = menu;

        }//FirstInitialised


        public void CreateRoom()
        {

            if (!PhotonNetwork.IsConnected)
                return;

            RoomOptions _options = new RoomOptions();
            _options.MaxPlayers = 5;
            PhotonNetwork.JoinOrCreateRoom(_roomName.text, _options, TypedLobby.Default);

        }//CreateRoom


        public override void OnCreatedRoom()
        {

            UnityEngine.Debug.Log(" Created room successfully", this);
            _menuCanvas.currentRoom.Show();


        }//OnCreatedRoom


        public override void OnCreateRoomFailed(short returnCode, string message)
        {

            UnityEngine.Debug.Log("Created room failed: " + message, this);

        }//OnCreateRoomFailed


 }// CREATE ROOM MENU
