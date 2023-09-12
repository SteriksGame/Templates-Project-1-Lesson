using UnityEngine;

public class OneTapAmmoGun : Gun
{
    [SerializeField] private int _bullets = 30;
    public override void Fire()
    {
        if(_bullets > 0)
        {
            Rigidbody bullet = Instantiate(BulletObject, TargetSpawn.transform.position, Quaternion.identity);
            bullet.AddRelativeForce(transform.forward * PowerForce);
            _bullets--;

            Debug.Log($"У {name} осталось - {_bullets} выстрелов");
        }
    }
}
