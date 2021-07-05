using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateOrJoinRoom : MonoBehaviour
{

        //Vars

        MenuCanvas menuCanvas;

        [SerializeField]
        CreateRoomMenu _createRoomMenu;

        [SerializeField]
        RoomListingsMenu _roomListings;

        //Funcs

        public void FirstInitialised(MenuCanvas _menuCanvas)
        {

            menuCanvas = _menuCanvas;
            _createRoomMenu.FirstInitialised(_menuCanvas);
            _roomListings.FirstInitialised(_menuCanvas);

        }//Initialised


}// CREATE OR JOIN ROOMS




