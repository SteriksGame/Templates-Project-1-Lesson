using UnityEngine;

public class Bullet : MonoBehaviour 
{
    private Rigidbody _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public void StartMove(Vector3 direction, float powerForce)
    {
        _rigidBody.AddRelativeForce(direction * powerForce);
    }
}
