using System;
using UnityEngine;

public class InputController
{
    public event Action PressedAlpha1;
    public event Action PressedAlpha2;
    public event Action PressedAlpha3;

    public event Action PressedMouse;

    public event Action PressedAction;

    private const float RANGE_FORWARD_VOLUME = 1;
    private const float RANGE_ROTATION_VOLUME = 1;

    public float ForwardMovement { get; private set; } = 0;
    public float RotationMovement { get; private set; } = 0;


    public void Update()
    {
        ForwardMovement = Input.GetAxis("Vertical") * RANGE_FORWARD_VOLUME;
        RotationMovement = Input.GetAxis("Horizontal") * RANGE_ROTATION_VOLUME;

        if (Input.GetKeyDown(KeyCode.Alpha1))
            PressedAlpha1?.Invoke();

        if (Input.GetKeyDown(KeyCode.Alpha2))
            PressedAlpha2?.Invoke();

        if (Input.GetKeyDown(KeyCode.Alpha3))
            PressedAlpha3?.Invoke();

        if (Input.GetKeyDown(KeyCode.Mouse0))
            PressedMouse?.Invoke();

        if (Input.GetKeyDown(KeyCode.E))
            PressedAction?.Invoke();
    }
}
