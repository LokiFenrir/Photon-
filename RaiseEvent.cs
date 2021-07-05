using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;

public class RaiseEvent : MonoBehaviourPun
{
    //Vars

    Renderer _renderer;

    const byte EVENT_CHANGE = 0;


    //Funcs

    void Awake()
    {

        _renderer = GetComponentInChildren<Renderer>();

    }//Awake


    void Update()
    {

        if (base.photonView.IsMine && Input.GetKeyDown(KeyCode.Space))
        {

            ColourChange();

        }

    }//Update


    void ColourChange()
    {


        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b= Random.Range(0f, 1f);

        _renderer.material.color = new Color(r, g, b, 1f);

        object[] data = new object[] { r, g, b };
        PhotonNetwork.RaiseEvent(EVENT_CHANGE, data, RaiseEventOptions.Default, SendOptions.SendUnreliable);

    }//ColourChange


    void OnEnable()
    {

        PhotonNetwork.NetworkingClient.EventReceived += NetworkingClient;

    }//OnEnable


    void NetworkingClient(EventData obj)
    {

        if (!base.photonView.IsMine)
        {

            if (obj.Code == EVENT_CHANGE)
            {

                object[] datas = (object[])obj.CustomData;
                float r = (float)datas[0];
                float g = (float)datas[1];
                float b = (float)datas[2];
                _renderer.material.color = new Color(r, g, b, 1f);

            }

        }


    }//NetworkingClient


}// RAISE EVENTS
