using UnityEngine;

public class ArmorShopTrader : IShop
{
    private GameObject _armorShopPanel;
    public ArmorShopTrader(GameObject shopPanel) => _armorShopPanel = shopPanel;

    public void CloseShop() => _armorShopPanel.SetActive(false);
    public void OpenShop() => _armorShopPanel.SetActive(true);
}
