using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleMenu : Menu {
    public Text text;

    private void OnEnable() {
        text.text = $"Welcome {Launcher.launcher.PlayerNick}!";
    }
}