using Photon.Realtime;
using Photon.Pun;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuManager : MonoBehaviour {
    public List<Menu> menus;
    public string startMenu;

    public static MenuManager manager;

    private Menu openedMenu = null;

    private void Awake() {
        manager = this;
    }

    private void Start() {
        CloseAllMenu();
        OpenMenu(startMenu);
    }

    public void CloseAllMenu() {
        foreach (Menu menu in menus) {
            menu.Close();
        }
        openedMenu = null;
    }

    public void OpenMenu(string menuName) {
        Menu menu = menus.Find(menu => menu.menuName == menuName);

        if (menu != null) {
            openedMenu?.Close();
            menu.Open();
            openedMenu = menu;
        }
        else {
            throw new System.Exception("Menu dosent exist");
        }
    }

    public void OpenMenu(Menu menu) {
        openedMenu?.Close();
        menu.Open();
        openedMenu = menu;
    }

    public void OpenErrorMenu(string errorMessage) {
        ErrorMenu menu = menus.Find(menu => menu.menuName == "ErrorMenu") as ErrorMenu;
        openedMenu.Close();
        menu.Open("errorMessage");
        openedMenu = menu;
    }

    public void OpenRoomMenu(string nameRoom) {
        RoomMenu menu = menus.Find(menu => menu.menuName == "RoomMenu") as RoomMenu;
        openedMenu.Close();
        menu.Open(nameRoom, PhotonNetwork.IsMasterClient);
        openedMenu = menu;
    }

    public void HostSwitch() {
        RoomMenu menu = menus.Find(menu => menu.menuName == "RoomMenu") as RoomMenu;
        menu.HostSwitch(PhotonNetwork.IsMasterClient);
    }

    public void RoomMenuCreatePlayer(List<Player> players) {
        RoomMenu menu = menus.Find(menu => menu.menuName == "RoomMenu") as RoomMenu;
        menu.CreatePlayers(players);
    }

    public void LeaveRoom() {
        Launcher.launcher.LeaveRoom();
    }

    public  void RoomListUpdate(List<RoomInfo> roomList) {
        FindRoom menu = menus.Find(menu => menu.menuName == "FindRoom") as FindRoom;

        menu.UpdateRoomList(roomList);
    }

    public void RoomListClear() {
        FindRoom menu = menus.Find(menu => menu.menuName == "FindRoom") as FindRoom;

        menu.ClearListRoom();
    }

    public void ExitGame() {
        PhotonNetwork.LeaveLobby();
        Application.Quit();
    }

    public void StartGame() {
        Launcher.launcher.StartGame();
    }
}