using UnityEngine;

public class TriplTapAmmoGun : Gun
{
    [SerializeField] private float _spawnOffsetAmmo = 0.05f;
    [SerializeField] private int _bullets = 30;
    public override void Fire()
    {
        if (_bullets > 2)
        {
            int offset = -1;
            for (int i = 3; i > 0; i--)
            {
                Rigidbody ammo = Instantiate(BulletObject, TargetSpawn.transform.position + new Vector3(offset * _spawnOffsetAmmo, 0), Quaternion.identity);
                ammo.AddRelativeForce(transform.forward * PowerForce);
                offset++;
                _bullets--;

                Debug.Log($"У {name} осталось - {_bullets} выстрелов");
            }  
        }
    }
}