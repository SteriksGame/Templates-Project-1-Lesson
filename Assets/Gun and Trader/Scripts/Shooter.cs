using System;

public class Shooter : IDisposable
{
    private Gun _currentGun;

    private InputController _inputPlayerController;

    public Shooter(InputController inputPlayerController)
    {
        _inputPlayerController = inputPlayerController;

        _inputPlayerController.PressedMouse += Fire;
    }

    public void Dispose()
    {
        _inputPlayerController.PressedMouse -= Fire;
    }

    public void SetGun(Gun gun)
    {
        _currentGun?.gameObject.SetActive(false);
        _currentGun = gun;
        _currentGun.gameObject.SetActive(true);
    }

    private void Fire()
    {
        if (_currentGun != null)
            _currentGun.Fire();
    }
}
