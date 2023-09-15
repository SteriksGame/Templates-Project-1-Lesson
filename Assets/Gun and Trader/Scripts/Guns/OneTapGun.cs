using UnityEngine;

public class OneTapGun : Gun
{
    public override void Fire()
    {
        Bullet bullet = Instantiate(BulletObject, TargetSpawn.transform.position, Quaternion.identity);
        bullet.StartMove(transform.forward, PowerForce);

        Debug.Log($"У {name} осталось - бесконечно выстрелов");
    }
}