using Photon.Realtime;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRoom : Menu {
    public Transform roomPlace;
    public GameObject roomItemPrefab;
    public List<RoomListItem> rooms;

    private void Awake() {
        rooms = new List<RoomListItem>();
    }

    public void UpdateRoomList(List<RoomInfo> roomList) {
        ClearListRoom();

        for (int i = 0; i < roomList.Count; ++i) {
            if (!roomList[i].RemovedFromList) {
                RoomListItem item = Instantiate(roomItemPrefab, roomPlace).GetComponent<RoomListItem>();

                item.SetUpData(roomList[i]);

                rooms.Add(item);
            }
        }
    }

    public void ClearListRoom() {
        for (int i = 0; i < rooms.Count; ++i) {
            Destroy(rooms[i].gameObject);
        }
        rooms.Clear();
    }
}