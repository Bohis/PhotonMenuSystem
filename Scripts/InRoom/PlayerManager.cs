using Photon.Pun;
using Photon.Realtime;
using Photon;

using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class PlayerManager : MonoBehaviourPunCallbacks{
    public PhotonView pv;

    private void Awake() {
        pv = GetComponent<PhotonView>();
    }

    private void Start() {
        if (pv.IsMine) {
            CreatePlayer();
        }
    }

    private void CreatePlayer() {
        Debug.Log("Create player " + PhotonNetwork.NickName);
    }

    public void LeaveRoom() {
        Destroy(GameObject.FindObjectOfType<RoomManager>().gameObject);
        PhotonNetwork.LeaveRoom();
        SceneManager.LoadScene(0);
    }

    public void LeaveGame() {
#if !UNITY_EDITOR
        Destroy(GameObject.FindObjectOfType<RoomManager>().gameObject);
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LeaveLobby();
        Application.Quit();
#endif
    }

    public void RespawnPlayer(int idPlayer) {
        CreatePlayer();
    }
}