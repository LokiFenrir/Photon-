using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersListing : MonoBehaviour
{

        //Vars

        [SerializeField]
        Text _text;

        public Player _player { get; private set; }


        //Func

        public void SetPlayerInfo(Player player)
        {

            _player = player;

            string _result = "None";
            if (player.CustomProperties.ContainsKey("PlayerName"))
                _result = (string)player.CustomProperties["PlayerName"];
            _text.text = _result.ToString();

        }//SetPlayerInfor


}// PLAYERS LISTING


