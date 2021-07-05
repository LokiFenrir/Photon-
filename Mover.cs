using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace PhotonNetworkTutorial
{


    public class Mover : MonoBehaviourPun, IPunObservable
    {

        //Vars

        const byte COLOUR_CHANGE = 0;


        //Func

        void Awake()
        {

            //PhotonNetwork.NetworkingClient.EventReceived += NetworkingClient;

        }//Awake


        void Start()
        {



        }//Start


        public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
        {

            if (stream.IsWriting)
            {

                stream.SendNext(transform.position);


            }
            else if (stream.IsReading)
            {

                transform.position = (Vector3)stream.ReceiveNext();

            }

        }//OnPhotonSerializeView


    }// MOVER

}//namespace PhotonNetworkTutorial

























/* public void Colour()
   {

       string value = (string)PhotonNetwork.LocalPlayer.CustomProperties["Colour"];
       Debug.Log(value);

       if(value == "Red")
       {

           _renderer.material.color = Color.red;

           object[] data = new object[] { Color.red };
           PhotonNetwork.RaiseEvent(COLOUR_CHANGE, data, RaiseEventOptions.Default, SendOptions.SendUnreliable);

           // Check for 2D texture change

       }
       else if(value == "Blue")
       {

           _renderer.material.color = Color.blue;

           object[] data = new object[] { Color.blue };
           PhotonNetwork.RaiseEvent(COLOUR_CHANGE, data, RaiseEventOptions.Default, SendOptions.SendUnreliable);


       }
       else if (value == "Green")
       {

           _renderer.material.color = Color.green;

           object[] data = new object[] { Color.green };
           PhotonNetwork.RaiseEvent(COLOUR_CHANGE, data, RaiseEventOptions.Default, SendOptions.SendUnreliable);


       }

   }


   void NetworkingClient(EventData obj)
   {

       if (!base.photonView.IsMine)
       {

           if(obj.Code == COLOUR_CHANGE)
           {

               object[] datas = (object[])obj.CustomData;
               Color color = (Color)datas[0];
               _renderer.material.color = color;

           }

       }

   }
   */
