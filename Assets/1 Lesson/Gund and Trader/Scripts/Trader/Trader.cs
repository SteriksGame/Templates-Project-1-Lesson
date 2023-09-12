using System;
using UnityEngine;

public class Trader : MonoBehaviour
{
    [SerializeField] private GameObject _frutShopPanel;
    [SerializeField] private GameObject _armorShopPanel;

    private IShop _currentShop;
    private bool _isInit = false;
    private bool _isEnter = false;

    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Player>())
        {
            if (_isInit == false) 
                throw new InvalidOperationException(nameof(_isInit));

            _currentShop.OpenShop();

            _isEnter = true;
        }

        if(other.GetComponent<Bullet>()) 
        {
            SetShop(new DontShopTrader());
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<Player>())
        {
            if (_isInit == false) 
                throw new InvalidOperationException(nameof(_isInit));

            _currentShop.CloseShop();

            _isEnter = false;
        }
    }

    public void Update()
    {
        if(_isEnter && Input.GetKeyDown(KeyCode.E))
        {
            switch (_currentShop)
            {
                case FrutShopTrader:
                    SetShop(new ArmorShopTrader(_armorShopPanel));
                    break;
                case ArmorShopTrader:
                    SetShop(new FrutShopTrader(_frutShopPanel));
                    break;
                default:
                    Debug.Log("Торговец раздраженно сверлит вас глазами.");
                    break;
            }
        }
    }

    private void Start() => Initializate();

    private void Initializate()
    {
        _currentShop = new FrutShopTrader(_frutShopPanel);
        _isInit = true;
    }

    private void SetShop(IShop shop)
    {
        if (_isInit == false) throw new InvalidOperationException(nameof(_isInit));

        _currentShop.CloseShop();

        _currentShop = shop;

        _currentShop.OpenShop();
    }
}
