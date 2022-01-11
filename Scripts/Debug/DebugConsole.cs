using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DebugConsole : MonoBehaviour {
    public static DebugConsole console;

    public Text log;
    public InputField commandField;

    public GameObject logObject;

    public UnityEvent<string> CommandHasBeenInput;


    private void Awake() {
        console = this;
        DontDestroyOnLoad(gameObject);

        commandField.onEndEdit.AddListener(CommandInput);
    }

    private void Start() {
        SetActiveLog(false);
        DataControls.Controls.Debug.Console.performed += _ => SetActiveLog(!logObject.activeSelf);
    }

    public void SetActiveLog(bool value) {
        logObject.SetActive(value);
    }

    private void CommandInput(string text) {
        AddLog(text);
        commandField.text = "";
        CommandHasBeenInput?.Invoke(text);
    }

    public void AddLog(string text) {
        Debug.Log(text);
        log.text += text + "\n";
    }
}