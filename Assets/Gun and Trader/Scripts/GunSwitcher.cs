using UnityEngine;

public class GunSwitcher : MonoBehaviour
{
    [SerializeField] private Gun OneTapAmmoGun;
    [SerializeField] private Gun OneTapGun;
    [SerializeField] private Gun TriplTapAmmoGun;

    [Space]
    [SerializeField] private Shooter _shooter;

    private InputController _inputController;

    public void Initializate(InputController inputController)
    {
        _inputController = inputController;
    }

    private void Start()
    {
        _inputController.PressedAlpha1 += SetOneTapAmmoGun;
        _inputController.PressedAlpha2 += SetOneTapGun;
        _inputController.PressedAlpha3 += SetTriplTapAmmoGun;

        SetOneTapAmmoGun();
    }

    private void SetOneTapAmmoGun() => _shooter.SetGun(OneTapAmmoGun);

    private void SetOneTapGun() => _shooter.SetGun(OneTapGun);

    private void SetTriplTapAmmoGun() => _shooter.SetGun(TriplTapAmmoGun);
}