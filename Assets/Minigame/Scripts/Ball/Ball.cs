using System;
using UnityEngine;

public class Ball : MonoBehaviour 
{
    public event Action<Ball> DestroyedBall;
    public enum TypesColor
    {
        Green,
        Red,
        White
    }

    [SerializeField] private TypesColor _typeColor;

    public TypesColor TypeColor => _typeColor;

    public void DestroyBall()
    {
        DestroyedBall?.Invoke(this);
        Destroy(gameObject);
    }
}
