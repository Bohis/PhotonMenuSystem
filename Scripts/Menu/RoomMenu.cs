using Photon.Realtime;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomMenu : Menu
{
    public Text roomName;
    public Transform playerPlace;
    public GameObject playerPrefabe;
    public List<PlayerItem> players;
    public GameObject buttonStart;

    private void Awake() {
        players = new List<PlayerItem>();
    }

    public void Open(string nameRoom, bool isMaster) {
        roomName.text = nameRoom;
        buttonStart.SetActive(isMaster);
        Open();
    }

    public void HostSwitch(bool isMaster) {
        buttonStart.SetActive(isMaster);
    }

    public void CreatePlayers(List<Player> playersList) {
        for(int i = 0; i < players.Count; ++i) {
            Destroy(players[i].gameObject);
        }

        players.Clear();

        for(int i = 0; i < playersList.Count; ++i) {
            PlayerItem player = Instantiate(playerPrefabe, playerPlace).GetComponent<PlayerItem>();
            player.SetUpData(playersList[i]);
            players.Add(player);
        }
    }
}
