using System.Collections.Generic;
using UnityEngine;

public class GameController
{
    private BallGenerator _ballGenerator;
    private GameplayHUD _gameplayHUD;

    private List<Ball> _ballsInGame;
    private IGameMode _gameMode;

    private MiniGameInputController _miniGameInputController;

    public GameController(MiniGameInputController miniGameInputController, BallGenerator ballGenerator, GameplayHUD gameplayHUD)
    {
        _miniGameInputController = miniGameInputController;
        _ballGenerator = ballGenerator;
        _gameplayHUD = gameplayHUD;
    }

    public void SetGameModeAndPlay(IGameMode gameMode)
    {
        _gameMode = gameMode;

        _ballsInGame = _ballGenerator.Generate();

        foreach (Ball ball in _ballsInGame)
            ball.DestroyedBall += OnBallDestroyed;

        _miniGameInputController.IsActiv = true;
    }

    private void OnBallDestroyed(Ball ball)
    {
        ball.DestroyedBall -= OnBallDestroyed;
        _ballsInGame.Remove(ball);

        if (_gameMode.IsWin(_ballsInGame))
        {
            _gameplayHUD.SetActiveResultMenu(true);
            _miniGameInputController.IsActiv = false;
        }
    }
}