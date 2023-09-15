using System;
using UnityEngine;

public class Trader : MonoBehaviour
{
    public event Action<Collider> EnteredCollider;
    public event Action<Collider> ExitedCollider;
    
    private bool _isEnter = false;

    public IShop CurrentShop { get; private set; }
    public bool IsEnter => _isEnter;

    public void SetShop(IShop shop)
    {
        CurrentShop?.Close();

        CurrentShop = shop;

        if(_isEnter)
            CurrentShop.Open();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Player>())
        {
            CurrentShop.Open();

            _isEnter = true;
        }

        EnteredCollider?.Invoke(other);
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<Player>())
        {
            CurrentShop.Close();

            _isEnter = false;
        }

        ExitedCollider?.Invoke(other);
    }
}
