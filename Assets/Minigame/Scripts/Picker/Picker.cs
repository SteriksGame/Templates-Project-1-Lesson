using UnityEngine;

public class Picker : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private MiniGameInputController _miniGameInputController;

    private bool _isInit = false;

    public void Initialized(MiniGameInputController miniGameInputController)
    {
        _miniGameInputController = miniGameInputController;

        _isInit = true;

        OnEnable();
    }

    private void OnEnable()
    {
        if (!_isInit)
            return;

        _miniGameInputController.PressedMouse += TakeBall;
    }

    private void OnDisable()
    {
        _miniGameInputController.PressedMouse -= TakeBall;
    }

    private void Update()
    {
        _miniGameInputController.Update();
    }

    private void TakeBall()
    {
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
