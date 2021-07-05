using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhotonNetworkTutorial
{

    public class OwnershipTransfer : MonoBehaviourPun, IPunOwnershipCallbacks
    {

        //Vars



        //Funcs

        void Awake()
        {

            PhotonNetwork.AddCallbackTarget(this);

        }//Awake


        void OnDestroy()
        {

            PhotonNetwork.RemoveCallbackTarget(this);

        }//OnDestroy


        void OnMouseDown()
        {

            base.photonView.RequestOwnership();

        }//OnMouseDown


        public void OnOwnershipRequest(PhotonView targetView, Player requestingPlayer)
        {

            if (targetView != base.photonView)
                return;

            //Add checks here.

            base.photonView.TransferOwnership(requestingPlayer);

        }//OnOwnershipRequest

        public void OnOwnershipTransfered(PhotonView targetView, Player previousOwner)
        {

            if (targetView != base.photonView)
                return;

        }//OnOwnershipTransered

        public void OnOwnershipTransferFailed(PhotonView targetView, Player senderOfFailedRequest)
        {



        }//OnOwnershipTransferFailed

        // This is used to transfer ownership of an item
        //object to the player for a capture the flag type 
        // gameMode.

    }// OWNERSHIP TRANSFER


}//namespace PHOTONNETWORK TUTORIAL
