using Photon.Realtime;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomListItem : MonoBehaviour
{
    public Text roomName;
    public RoomInfo room;

    public void SetUpData(RoomInfo info) {
        roomName.text = info.Name;
        room = info;
    }

    public void OnJoinRoom() {
        Launcher.launcher.JoinRoom(room);
    }
}
