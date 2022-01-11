using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using System.IO;

public class RoomManager : MonoBehaviourPunCallbacks {
    public static RoomManager manager;

    private void Awake() {
        if (manager) {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        manager = this;
    }

    private new void OnDisable() {
        base.OnDisable();
        SceneManager.sceneLoaded -= SceneManager_sceneLoaded;
    }

    private new void OnEnable() {
        base.OnEnable();
        SceneManager.sceneLoaded += SceneManager_sceneLoaded;
    }

    private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode arg1) {
        if (scene.buildIndex == 1) {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs",  "InRoom","PlayerManager"), Vector3.zero, Quaternion.identity);
        }
    }
}