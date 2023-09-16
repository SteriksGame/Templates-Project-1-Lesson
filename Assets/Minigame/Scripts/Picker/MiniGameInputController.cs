using System;
using UnityEngine;

public class MiniGameInputController
{
    public event Action PressedMouse;

    public bool IsActiv = false;

    public void Update()
    {
        if (!IsActiv)
            return;

        if (Input.GetKeyDown(KeyCode.Mouse0))
            PressedMouse?.Invoke();
    }
}
