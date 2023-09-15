using UnityEngine;

public class FrutShopTrader : IShop
{
    private GameObject _frutShopPanel;
    public FrutShopTrader(GameObject shopPanel) => _frutShopPanel = shopPanel;

    public void Close()
    {
        Debug.Log("Закрывает витрину с фруктами");
        _frutShopPanel.SetActive(false);
    }
    public void Open()
    {
        Debug.Log("Открывает витрину с фруктами");
        _frutShopPanel.SetActive(true);
    }
}
