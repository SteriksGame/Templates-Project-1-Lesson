using UnityEngine;

public class MiniGameEntryPoint : MonoBehaviour
{
    [SerializeField] private Picker _picker;
    [SerializeField] private BallGenerator _ballGenerator;
    [SerializeField] private GameplayHUD _gameplayHUD;

    private void Awake()
    {
        MiniGameInputController miniGameInputController = new MiniGameInputController();

        _picker.Initialized(miniGameInputController);

        GameController gameController = new GameController(miniGameInputController, _ballGenerator, _gameplayHUD);
        GameModeSwitcher gameModeSwitcher = new GameModeSwitcher(gameController, _gameplayHUD);
    }
}
