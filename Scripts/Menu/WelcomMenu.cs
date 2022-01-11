using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class WelcomMenu : Menu {
    public Text nickName;

    public void OnEnterGame() {
        Launcher.launcher.ConnectToServer(nickName.text); 
    }
}