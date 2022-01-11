using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCreateRoom : Menu
{
    public Text createMenuName;
    public void CreateRoom() {
        if (createMenuName.text != "") {
            Launcher.launcher.CreateRoom(createMenuName.text);
        }
    }
}
