using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Launcher : MonoBehaviourPunCallbacks {
    public static Launcher launcher;

    private void Awake() {
        launcher = this;
    }

    void Start() {
        DebugConsole.console.AddLog("Conneting master");
        DataControls.EnableControll();
    }

    // коннект используя настройки
    public void ConnectToServer(string nickName) {
        PhotonNetwork.NickName = nickName;
        MenuManager.manager.OpenMenu("LoadingMenu");
        PhotonNetwork.ConnectUsingSettings();
    }
    
    // Когда законестелись к мастеру
    public override void OnConnectedToMaster() {
        DebugConsole.console.AddLog("Join master");
        PhotonNetwork.JoinLobby();
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    // При присоеденении к лоби
    public override void OnJoinedLobby() {
        // Открыть главное меню
        MenuManager.manager.OpenMenu("TitleMenu");
        DebugConsole.console.AddLog("Join Lobby");
    }

    public void StartGame() {
        PhotonNetwork.LoadLevel(1);
    }

    public string PlayerNick {
        get => PhotonNetwork.NickName;
    }

    public void CreateRoom(string menuName) {
        DebugConsole.console.AddLog("Creating room");
        PhotonNetwork.CreateRoom(menuName);
        MenuManager.manager.OpenMenu("LoadingMenu");
    }

    public override void OnJoinedRoom() {
        DebugConsole.console.AddLog("Join room");
        MenuManager.manager.OpenRoomMenu(PhotonNetwork.CurrentRoom.Name);
        MenuManager.manager.RoomMenuCreatePlayer(new List<Player>(PhotonNetwork.CurrentRoom.Players.Values));
    }

    public override void OnCreateRoomFailed(short returnCode, string message) {
        DebugConsole.console.AddLog($"Creating room failed, {returnCode}: {message}");
        MenuManager.manager.OpenErrorMenu($"{returnCode}: {message}");
    }

    public void LeaveRoom() {
        PhotonNetwork.LeaveRoom();
        MenuManager.manager.OpenMenu("LoadingMenu");
    }

    public override void OnLeftRoom() {
        MenuManager.manager.OpenMenu("TitleMenu");
        MenuManager.manager.RoomListClear();
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList) {
        MenuManager.manager.RoomListUpdate(roomList);
    }

    public void JoinRoom(RoomInfo room) {
        PhotonNetwork.JoinRoom(room.Name);
        MenuManager.manager.OpenMenu("LoadingMenu");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer) {
        MenuManager.manager.RoomMenuCreatePlayer(new List<Player>(PhotonNetwork.CurrentRoom.Players.Values));
    }

    public override void OnPlayerLeftRoom(Player otherPlayer) {
        MenuManager.manager.RoomMenuCreatePlayer(new List<Player>(PhotonNetwork.CurrentRoom.Players.Values));
    }

    public override void OnMasterClientSwitched(Player newMasterClient) {
        MenuManager.manager.HostSwitch();
    }
}