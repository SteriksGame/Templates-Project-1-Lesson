using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private BallGenerator _ballGenerator;
    [SerializeField] private GameplayHUD _gameplayHUD;

    private List<Ball> _ballsInGame;
    private GameMode _gameMode;
    private bool _inPlay = false;

    public bool InPlay => _inPlay;

    public void SetGameModeAndPlay(GameMode gameMode)
    {
        _gameMode = gameMode;

        _ballsInGame = _ballGenerator.Generate();

        foreach (Ball ball in _ballsInGame)
            ball.DestroyedBall += ChangeBallInGame;

        _inPlay = true;
    }

    private void ChangeBallInGame(Ball ball)
    {
        _ballsInGame.Remove(ball);

        if (_gameMode.CheckWinGame(_ballsInGame))
        {
            _gameplayHUD.SetActiveResultMenu(true);
            _inPlay = false;
        }
    }
}