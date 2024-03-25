using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ubiq.Rooms;
using System.ComponentModel;
using System;
namespace Ubiq.Samples
{
    public class NewRoomButton : MonoBehaviour
    {
        //public SocialMenu mainMenu;
        //public Text nameText;
        //public bool publish;

        //// Expected to be called by a UI element
        //public void NewRoom ()
        //{
        //    mainMenu.roomClient.Join(
        //        name: nameText.text,
        //        publish: publish);
        //}
        private List<IRoom> available = new List<IRoom>();
        public RoomClient roomClient;
        private void Awake()
        {
            roomClient.OnRooms.AddListener(RoomClient_OnRoomsDiscovered);
        }
        public void Update()
        {
            if (available.Count == 0)
            {
                roomClient.DiscoverRooms();
            }
        }
        public void NewRoom()
        {
            roomClient.Join(name: $"Editor Room {IdGenerator.GenerateUnique().ToString()}", publish: true);
        }
        public void JoinRoom()
        {
            if (available != null)
            {
                for (int i = 0; i < Math.Min(available.Count, 5); i++)
                {
                    var room = available[i];
                    
                    roomClient.Join(joincode: room.JoinCode);
                    Debug.Log("Join room: "+ room.Name);
                }
            }
        }

        private void RoomClient_OnRoomsDiscovered(List<IRoom> rooms, RoomsDiscoveredRequest request)
        {
            // We're interested only in requests for all rooms
            if (!string.IsNullOrEmpty(request.joincode))
            {
                return;
            }

            available = new List<IRoom>(rooms);
        }
        private void OnDestroy()
        {
           roomClient.OnRooms.RemoveListener(RoomClient_OnRoomsDiscovered);
        }


    }
}
