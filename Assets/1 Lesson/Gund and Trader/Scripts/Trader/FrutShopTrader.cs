using UnityEngine;

public class FrutShopTrader : IShop
{
    private GameObject _frutShopPanel;
    public FrutShopTrader(GameObject shopPanel) => _frutShopPanel = shopPanel;

    public void CloseShop() => _frutShopPanel.SetActive(false);
    public void OpenShop() => _frutShopPanel.SetActive(true);
}
