using UnityEngine;

public class GameModeSwitcher : MonoBehaviour
{
    [SerializeField] private GameController _gameController;
    [SerializeField] private GameplayHUD _gameplayHUD;

    public void SetAllBallGame()
    {
        _gameController.SetGameModeAndPlay(new AllBallGameMode());
    }

    public void SetOnlyOneColorBallGame()
    {
        _gameController.SetGameModeAndPlay(new OnlyOneColorBallGameMode());
    }

    private void Start()
    {    
        _gameplayHUD.StartedAllBallGameButton += SetAllBallGame;
        _gameplayHUD.StartedOnlyOneColorBallGameButton += SetOnlyOneColorBallGame;
    }
}
