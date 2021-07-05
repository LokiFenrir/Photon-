using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PhotonNetworkTutorial
{


    public class EnterPlayerStats : MonoBehaviour
    {

        //Vars

        private ExitGames.Client.Photon.Hashtable _name = new ExitGames.Client.Photon.Hashtable();

        [SerializeField]
        Text _nameText;

        //Funcs

        void SetName()
        {

            _name["PlayerName"] = _nameText.text.ToString();
            _nameText.text = PhotonNetwork.NickName;
            PhotonNetwork.SetPlayerCustomProperties(_name);

            //To Remove the property _customProperties.Remove("RandomNumber");

        }

        public void Update()
        {

            SetName();

        }


    }// RANDOM CUSTOM GENERATOR

}//nameSpacePhotonNetworkTutorial
