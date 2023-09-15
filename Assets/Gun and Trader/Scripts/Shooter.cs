using UnityEngine;

public class Shooter : MonoBehaviour
{
    private Gun _currentGun;

    private InputController _inputPlayerController;

    public void Initializate(InputController inputPlayerController)
    {
        _inputPlayerController = inputPlayerController;
    }

    public void SetGun(Gun gun)
    {
        _currentGun?.gameObject.SetActive(false);
        _currentGun = gun;
        _currentGun.gameObject.SetActive(true);
    }

    private void Start()
    {
        _inputPlayerController.PressedMouse += Fire;
    }

    private void Fire()
    {
        if (_currentGun != null)
            _currentGun.Fire();
    }
}
