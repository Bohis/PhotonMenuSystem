using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;


public class PlayerItem : MonoBehaviour
{
    public Text playerName;
    public Player player;

    public void SetUpData(Player player) {
        this.player = player;
        playerName.text = player.NickName;
    }
}
