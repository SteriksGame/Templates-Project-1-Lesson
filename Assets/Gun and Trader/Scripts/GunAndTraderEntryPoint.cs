using UnityEngine;

public class GunAndTraderEntryPoint : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GunSwitcher _gunSwitcher;
    [SerializeField] private TraderSwitcher _traderSwitcher;

    private void Awake()
    {
        InputController inputController = new InputController();
        Shooter shooter = new Shooter(inputController);

        _player.Initializate(inputController);
        _gunSwitcher.Initializate(inputController, shooter);
        _traderSwitcher.Initializate(inputController);
    }
}
