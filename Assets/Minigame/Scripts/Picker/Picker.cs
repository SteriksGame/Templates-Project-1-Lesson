using UnityEngine;

public class Picker : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private GameController _gameController;

    private MiniGameInputController _miniGameInputController;

    public void Initialized(MiniGameInputController miniGameInputController)
    {
        _miniGameInputController = miniGameInputController;
    }

    private void Start()
    {
        _miniGameInputController.PressedMouse += TakeBall;
    }

    private void Update()
    {
        _miniGameInputController.Update();
    }

    private void TakeBall()
    {
        if (!_gameController.InPlay) return;

        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.TryGetComponent(out Ball ball))
            {
                ball.DestroyBall();
            }
        }
    }
}
