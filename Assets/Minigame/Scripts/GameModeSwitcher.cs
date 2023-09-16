using System;
public class GameModeSwitcher : IDisposable
{
    private GameController _gameController;
    private GameplayHUD _gameplayHUD;

    public GameModeSwitcher(GameController gameController, GameplayHUD gameplayHUD)
    {
        _gameController = gameController;
        _gameplayHUD = gameplayHUD;

        _gameplayHUD.StartedAllBallGameButton += SetAllBallGame;
        _gameplayHUD.StartedOnlyOneColorBallGameButton += SetOnlyOneColorBallGame;
    }

    public void Dispose()
    {
        _gameplayHUD.StartedAllBallGameButton -= SetAllBallGame;
        _gameplayHUD.StartedOnlyOneColorBallGameButton -= SetOnlyOneColorBallGame;
    }

    public void SetAllBallGame()
    {
        _gameController.SetGameModeAndPlay(new AllBallGameMode());
    }

    public void SetOnlyOneColorBallGame()
    {
        _gameController.SetGameModeAndPlay(new OnlyOneColorBallGameMode());
    }
}
