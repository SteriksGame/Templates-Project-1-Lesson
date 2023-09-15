using System;
using UnityEngine;

public class MiniGameInputController
{
    public event Action PressedMouse;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            PressedMouse?.Invoke();
    }
}
