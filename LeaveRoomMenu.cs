using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveRoomMenu : MonoBehaviour 
{

        //Vars

        MenuCanvas _menuCanvas;


        //Func

        public void FirstInitialised(MenuCanvas menuCanvas)
        {

            _menuCanvas = menuCanvas;

        }//FirstInitialsed


        public void LeaveRoom()
        {

            PhotonNetwork.LeaveRoom(true);
            _menuCanvas.currentRoom.Hide();

        }//LeaveRoom

}//LeaveRoomMenu


