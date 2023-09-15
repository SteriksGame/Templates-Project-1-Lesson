using UnityEngine;

public class TriplTapAmmoGun : Gun
{
    [SerializeField] private float _distanceBetweenBullets = 0.05f;
    [SerializeField] private int _bullets = 30;

    private const int _bulletsToFire = 3;

    public override void Fire()
    {
        if (_bullets >= _bulletsToFire)
        {
            int transformOffset = Mathf.FloorToInt(_bulletsToFire / 2);

            for (int i = _bulletsToFire; i > 0; i--)
            {
                Vector3 spawnPosition = TargetSpawn.transform.position + new Vector3(transformOffset * _distanceBetweenBullets, 0);
                Bullet bullet = Instantiate(BulletObject, spawnPosition, Quaternion.identity);
                bullet.StartMove(transform.forward, PowerForce);

                transformOffset--;
                _bullets--;

                Debug.Log($"У {name} осталось - {_bullets} выстрелов");
            }  
        }
        else
            Debug.Log("Перезарядись!");
    }
}