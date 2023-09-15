using System;
using UnityEngine;

public class GameplayHUD : MonoBehaviour
{
    public event Action StartedAllBallGameButton;
    public event Action StartedOnlyOneColorBallGameButton;

    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _resultMenu;

    public void SetActiveMainMenu(bool activ) => _mainMenu.SetActive(activ);

    public void SetActiveResultMenu(bool activ) => _resultMenu.SetActive(activ);

    public void StartAllBallGameButton()
    {
        SetActiveMainMenu(false);
        StartedAllBallGameButton?.Invoke();
    }

    public void StartOnlyOneColorBallGameButton()
    {
        SetActiveMainMenu(false);
        StartedOnlyOneColorBallGameButton?.Invoke();
    }
}
