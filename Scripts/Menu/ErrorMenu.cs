using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorMenu : Menu
{
    public Text errorText;
    public void Open(string message) {
        errorText.text = message;
        Open();
    }
}
