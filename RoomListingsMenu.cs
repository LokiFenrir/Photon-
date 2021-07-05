using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhotonNetworkTutorial;

public class RoomListingsMenu : MonoBehaviourPunCallbacks
{

    //Vars

    [SerializeField]
    RoomListing _roomListingsPrefab;
    [SerializeField]
    Transform _content;

    List<RoomListing> _listings = new List<RoomListing>();

    MenuCanvas _menuCanvas;


    //Funcs


    public void FirstInitialised(MenuCanvas canvas)
    {

        _menuCanvas = canvas;

    }//FirstInitialised


    public override void OnJoinedRoom()
    {

        _menuCanvas.currentRoom.Show();
        _content.DestroyChilren();
        _listings.Clear();

    }//OnJoinedRoom


    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {

        foreach(RoomInfo info in roomList)
        {

            if (info.RemovedFromList)
            {

                //Removed from List
                int index = _listings.FindIndex(x => x._roomInfo.Name == info.Name);
                if(index != -1)
                {

                    Destroy(_listings[index].gameObject);
                    _listings.RemoveAt(index);

                }

            }
            else
            {

                //Added to List
                int index = _listings.FindIndex(x => x._roomInfo.Name == info.Name);
                if(index == -1)
                {

                    RoomListing listing = Instantiate(_roomListingsPrefab, _content);
                    if (listing != null)
                    {

                        listing.SetRoomInfo(info);
                        _listings.Add(listing);

                    }

                }

            }

        }

    }//OnRoomListUpdate


}// ROOM LISTINGS MENU
