using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    [Space]
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _resultMenu;

    [Space]
    [SerializeField] private BallGenerator _ballGenerator;

    private GameMode _gameMode;
    private bool isPlay = false;

    public void StartAllBallGame()
    {
        _gameMode = new AllBallGameMode(_ballGenerator);
        StartGame();
    }
    public void StartOnlyOneColorBallGame()
    {
        _gameMode = new OnlyOneColorBallGameMode(_ballGenerator);
        StartGame();
    }
    public void ResultGame()
    {
        _resultMenu.SetActive(true);
        isPlay = false;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isPlay)
        {
            RaycastHit hit;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.TryGetComponent(out Ball ball))
                {
                    _ballGenerator.RemoveBall(ball);

                    if (_gameMode.CheckResult())
                        ResultGame();
                }
            }
        }
    }
    private void StartGame()
    {
        _mainMenu.SetActive(false);
        _ballGenerator.Generation();
        isPlay = true;
    }
}
