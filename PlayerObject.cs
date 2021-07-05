using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviourPunCallbacks
{

    //Vars

    [SerializeField]
    GameObject _characterPrefab;

    //Funcs

    void Awake()
    {

        Vector2 offset = Random.insideUnitCircle * 3f;
        Vector3 _pos = new Vector3(transform.position.x * offset.x, transform.position.y * offset.y, transform.position.z);

        GameObject player = PhotonNetwork.Instantiate("Ninjas_Character", _pos, Quaternion.identity);


    }//Awake


   /* public static GameObject NetworkInstatiate(GameObject obj, Vector3 pos, Quaternion rot)
    {

        foreach (NetworkPrefab networkPrefab in t_networkPrefabs)
        {

            if (networkPrefab._prefab == obj)
            {


                if (networkPrefab._path != string.Empty)
                {

                    GameObject result = PhotonNetwork.Instantiate(networkPrefab._path, pos, rot);
                    return result;

                }
                else
                {

                    Debug.LogError("Path is empty for gameobject name " + networkPrefab._prefab);
                    return null;

                }

            }

        }

        return null;

    }//NetworkInstatitate


    //Funcs

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void PopulateNetworkPrefabs()
    {

#if UNITY_EDITOR

        Instance._networkPrefabs.Clear();

        GameObject[] results = Resources.LoadAll<GameObject>("");
        for (int i = 0; i < results.Length; i++)
        {

            if (results[i].GetComponent<PhotonView>() != null)
            {

                string path = AssetDatabase.GetAssetPath(results[i]);
                Instance._networkPrefabs.Add(new NetworkPrefab(results[i], path));

            }

        }

#endif

    }//PopulateNetworkPrefabs
    */

}// PLAYER OBJECT
