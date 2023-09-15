using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 10f;
    [SerializeField] private float _rotationSpeed = 1f;

    private Rigidbody _rigidbody;
    private InputController _inputController;

    public void Initializate(InputController inputController)
    {
        _inputController = inputController;
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _inputController.Update();
    }

    private void FixedUpdate()
    {
        Move();
        Rotate();
    }

    private void Move() => _rigidbody.AddRelativeForce(new Vector3(0, 0, _inputController.ForwardMovement) * _movementSpeed);

    private void Rotate() => transform.Rotate(0, _inputController.RotationMovement * _rotationSpeed, 0);
}
