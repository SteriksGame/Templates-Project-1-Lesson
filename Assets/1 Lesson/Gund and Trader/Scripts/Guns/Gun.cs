using UnityEngine;

public class Gun : MonoBehaviour
{
    [field:SerializeField] public Transform TargetSpawn { get; private set; }
    [field:SerializeField] public Rigidbody BulletObject { get; private set; }
    [field: SerializeField] public float PowerForce { get; private set; } = 1000f;
    
    public virtual void Fire() { }
}
