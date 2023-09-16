using UnityEngine;

public class GunSwitcher : MonoBehaviour
{
    [SerializeField] private Gun OneTapAmmoGun;
    [SerializeField] private Gun OneTapGun;
    [SerializeField] private Gun TriplTapAmmoGun;

    private Shooter _shooter;
    private InputController _inputController;

    private bool _isInit = false;

    public void Initializate(InputController inputController, Shooter shooter)
    {
        _inputController = inputController;
        _shooter = shooter;

        _isInit = true;

        OnEnable();
    }

    private void Start()
    {
        SetOneTapAmmoGun();
    }

    private void OnEnable()
    {
        if (!_isInit)
            return;

        _inputController.PressedAlpha1 += SetOneTapAmmoGun;
        _inputController.PressedAlpha2 += SetOneTapGun;
        _inputController.PressedAlpha3 += SetTriplTapAmmoGun;
    }

    private void OnDisable()
    {
        _inputController.PressedAlpha1 -= SetOneTapAmmoGun;
        _inputController.PressedAlpha2 -= SetOneTapGun;
        _inputController.PressedAlpha3 -= SetTriplTapAmmoGun;
    }

    private void SetOneTapAmmoGun() => _shooter.SetGun(OneTapAmmoGun);

    private void SetOneTapGun() => _shooter.SetGun(OneTapGun);

    private void SetTriplTapAmmoGun() => _shooter.SetGun(TriplTapAmmoGun);
}