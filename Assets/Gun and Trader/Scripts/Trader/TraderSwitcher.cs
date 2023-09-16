using UnityEngine;

public class TraderSwitcher : MonoBehaviour
{
    [SerializeField] private Trader _trader;

    [Space]
    [SerializeField] private GameObject _frutShopPanel;
    [SerializeField] private GameObject _armorShopPanel;

    private InputController _inputController;

    private bool _isInit = false;

    public void Initializate(InputController inputController)
    {
        _inputController = inputController;

        _isInit = true;

        OnEnable();
    }

    private void Start()
    {
        _trader.SetShop(new ArmorShopTrader(_armorShopPanel));
    }

    private void OnEnable()
    {
        if (!_isInit)
            return;

        _inputController.PressedAction += ChangeShop;
        _trader.EnteredCollider += CheckingFireAtTheTrader;
    }

    private void OnDisable()
    {
        _inputController.PressedAction -= ChangeShop;
        _trader.EnteredCollider -= CheckingFireAtTheTrader;
    }

    private void CheckingFireAtTheTrader(Collider other)
    {
        if (other.GetComponent<Bullet>())
            _trader.SetShop(new DontShopTrader());
    }

    private void ChangeShop()
    {
        if (_trader.IsEnter)
        {
            switch (_trader.CurrentShop)
            {
                case FrutShopTrader:
                    _trader.SetShop(new ArmorShopTrader(_armorShopPanel));
                    break;

                case ArmorShopTrader:
                    _trader.SetShop(new FrutShopTrader(_frutShopPanel));
                    break;

                default:
                    Debug.Log("Торговец раздраженно сверлит вас глазами.");
                    break;
            }
        }
    }
}
