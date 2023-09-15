using UnityEngine;

public class ArmorShopTrader : IShop
{
    private GameObject _armorShopPanel;
    public ArmorShopTrader(GameObject shopPanel) => _armorShopPanel = shopPanel;

    public void Close()
    {
        Debug.Log("Закрывает витрину с броей");
        _armorShopPanel.SetActive(false);
    }
    public void Open()
    {
        Debug.Log("Открывает витрину с броней");
        _armorShopPanel.SetActive(true);
    }
}
