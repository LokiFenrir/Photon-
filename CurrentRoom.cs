using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRoom : MonoBehaviour
{

        //Vars

        [SerializeField]
        PlayerListMenu _playerListMenu;
        [SerializeField]
        LeaveRoomMenu _leaveRoomMenu;
        public LeaveRoomMenu leaveRoomMenu { get { return _leaveRoomMenu; } }

        MenuCanvas menuCanvas;


        //Funcs

        public void FirstInitialised(MenuCanvas _menuCanvas)
        {

            menuCanvas = _menuCanvas;
            _playerListMenu.FirstInitialised(menuCanvas);
            _leaveRoomMenu.FirstInitialised(menuCanvas);

        }//Initialised


        public void Show()
        {

            gameObject.SetActive(true);

        }


        public void Hide()
        {

            gameObject.SetActive(false);

        }


 }// CURRENT ROOM


