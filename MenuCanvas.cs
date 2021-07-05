using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class MenuCanvas : MonoBehaviour
 {

        //Vars

        [SerializeField]
        CreateOrJoinRoom _createOrJoinRoom;

        public CreateOrJoinRoom createOrJoinRoom { get { return _createOrJoinRoom; } }


        [SerializeField]
        CurrentRoom _currentRoom;

        public CurrentRoom currentRoom { get { return _currentRoom; } }



        //Func

        private void Awake()
        {

            FirstInitialised();

        }//Awake


        public void FirstInitialised()
        {

            createOrJoinRoom.FirstInitialised(this);
            currentRoom.FirstInitialised(this);

        }//FirstInitialised


 }// MENU CANVAS
