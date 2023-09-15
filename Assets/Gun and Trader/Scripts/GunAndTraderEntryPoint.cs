using UnityEngine;

public class GunAndTraderEntryPoint : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Shooter _shooter;
    [SerializeField] private GunSwitcher _gunSwitcher;
    [SerializeField] private TraderSwitcher _traderSwitcher;

    void Awake()
    {
        InputController inputController = new InputController();

        _player.Initializate(inputController);
        _shooter.Initializate(inputController);
        _gunSwitcher.Initializate(inputController);
        _traderSwitcher.Initializate(inputController);
    }
}
