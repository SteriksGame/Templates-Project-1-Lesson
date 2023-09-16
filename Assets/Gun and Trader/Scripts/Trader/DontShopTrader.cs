using UnityEngine;

public class DontShopTrader : IShop
{
    public void Close() => Debug.Log("Торговец провожает вас взглядом");
    public void Open() => Debug.Log("Торговец не в настроении");
}
