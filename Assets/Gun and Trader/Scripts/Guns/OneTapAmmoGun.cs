using UnityEngine;

public class OneTapAmmoGun : Gun
{
    [SerializeField] private int _bullets = 30;

    private const int _bulletsToFire = 1;

    public override void Fire()
    {
        if (_bullets >= _bulletsToFire)
        {
            Bullet bullet = Instantiate(BulletObject, TargetSpawn.transform.position, Quaternion.identity);
            bullet.StartMove(transform.forward, PowerForce);
            _bullets--;

            Debug.Log($"У {name} осталось - {_bullets} выстрелов");
        }
        else
            Debug.Log("Перезарядись!");
    }
}
