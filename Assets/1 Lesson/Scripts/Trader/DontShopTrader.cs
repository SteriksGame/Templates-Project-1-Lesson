using UnityEngine;

public class DontShopTrader : IShop
{
    public DontShopTrader() { }
    public void CloseShop() => Debug.Log("Торговец провожает вас взглядом");
    public void OpenShop() => Debug.Log("Торговец не в настроении");
}
