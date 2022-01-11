using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataControls {
    public static Controls Controls = new Controls();

    public static void EnableControll() {
        Controls.Enable();
    }

    public static void DisableControl() {
        Controls.Disable();
    }
}