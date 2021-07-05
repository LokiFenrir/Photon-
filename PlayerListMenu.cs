using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;


public class PlayerListMenu : MonoBehaviourPunCallbacks
{


        //Vars

        [SerializeField]
        PlayersListing _playerListing;
        [SerializeField]
        Transform _content;

        [SerializeField]
        GameObject startBtn;

        List<PlayersListing> _listings = new List<PlayersListing>();
        MenuCanvas _menuCanvas;

        [SerializeField]
        GameObject customPanel;

        //Func

        public void FirstInitialised(MenuCanvas canvas)
        {

            _menuCanvas = canvas;

        }//FirstInitialised



        public override void OnEnable()
        {

            GetCurrentRoomPlayers();
            customPanel.SetActive(false);

        }//OnEnable


        public override void OnDisable()
        {

            for (int i = 0; i < _listings.Count; i++)
            {

                Destroy(_listings[i].gameObject);

            }

            _listings.Clear();

        }//OnDisable


        public void GetCurrentRoomPlayers()
        {
            if (!PhotonNetwork.IsConnected)
                return;

            if (PhotonNetwork.CurrentRoom == null || PhotonNetwork.CurrentRoom.Players == null)
                return;

            foreach (Player p in PhotonNetwork.PlayerList)
            {

                AddPlayerListing(p);

            }

            

        }//CurrentRoomPlayers


        void AddPlayerListing(Player player)
        {

            int index = _listings.FindIndex(x => x._player == player);
            if (index != -1)
            {

                _listings[index].SetPlayerInfo(player);

            }
            else
            {

                PlayersListing listing = Instantiate(_playerListing, _content);
                if (listing != null)
                {

                    listing.SetPlayerInfo(player);
                    _listings.Add(listing);

                }

            }

        }//AddPlayerListing


        public override void OnPlayerEnteredRoom(Player newPlayer)
        {

            AddPlayerListing(newPlayer);
            GetCurrentRoomPlayers();

        }//OnPlayerEnteredRoom


        public override void OnPlayerLeftRoom(Player otherPlayer)
        {

            //Removed from List
            int index = _listings.FindIndex(x => x._player == otherPlayer);
            if (index != -1)
            {

                Destroy(_listings[index].gameObject);
                _listings.RemoveAt(index);

            }

        }//OnPlayerLeftRoom


        public void StartGame()
        {

            if (PhotonNetwork.IsMasterClient)
            {

                PhotonNetwork.CurrentRoom.IsOpen = false;
                PhotonNetwork.CurrentRoom.IsVisible = false;
                PhotonNetwork.LoadLevel("Game_Scene");

            }


        }//StartGame


        private void Update()
        {

            if (!PhotonNetwork.IsMasterClient)
                startBtn.SetActive(false);

            GetCurrentRoomPlayers();

        }//Update


        public override void OnMasterClientSwitched(Player newMasterClient)
        {

            _menuCanvas.currentRoom.leaveRoomMenu.LeaveRoom();

        }//OnMasterClientSwitched


        public void CustomisePanel()
        {

            customPanel.SetActive(true);

        }//CustomisePanel


        public void ExitCustomisePanel()
        {

            customPanel.SetActive(false);

        }//ExitCustomisePanel


}// PLAYER LIST MENU



