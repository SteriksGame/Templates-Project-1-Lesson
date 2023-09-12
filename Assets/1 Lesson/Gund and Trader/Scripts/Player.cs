using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private List<Gun> _gunsList;
    
    [SerializeField] private float _movementSpeed = 10f;
    [SerializeField] private float _rotationSpeed = 1f;

    private float _forwardMovement = 0;
    private float _rotationMovement = 0;

    private Gun _currentGun;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();

        SwitchGun(0);
    }
    private void Update()
    {
        _forwardMovement = Input.GetAxis("Vertical");
        _rotationMovement = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Alpha1)) SwitchGun(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) SwitchGun(1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) SwitchGun(2);

        if (Input.GetKeyDown(KeyCode.Mouse0) && _currentGun != null) _currentGun.Fire(); 
    }
    private void FixedUpdate()
    {
        Transform();
        Rotation();
    }

    private void Transform() => _rb.AddRelativeForce(new Vector3(0, 0, _forwardMovement) * _movementSpeed);
    private void Rotation() => transform.Rotate(0, _rotationMovement * _rotationSpeed, 0);

    private void SwitchGun(int indexGun)
    {
        if(_currentGun == _gunsList[indexGun]) 
            return;

        _currentGun?.gameObject.SetActive(false);

        _currentGun = _gunsList[indexGun];
        _currentGun.gameObject.SetActive(true);
    }
}
