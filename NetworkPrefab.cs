using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;

[System.Serializable]
public class NetworkPrefab
{


    //Vars

    public GameObject _prefab;
    public string _path;

    public NetworkPrefab(GameObject obj, string path)
    {

        _prefab = obj;
        _path = PathModified(path);

    }// Network prefab


    string PathModified(string path)
    {

        int externsionLength = System.IO.Path.GetExtension(path).Length;
        int additionalLength = 10;
        int startIndex = path.ToLower().IndexOf("resources");

        if(startIndex == -1)
        {

            return string.Empty;

        }
        else
        {

            return path.Substring(startIndex + additionalLength, path.Length - (additionalLength + startIndex + externsionLength));

        }

    }//PathModified


    //Funcs



}// NETWORK PREFAB
