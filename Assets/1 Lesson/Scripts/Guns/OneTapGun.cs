using UnityEngine;

public class OneTapGun : Gun
{
    public override void Fire()
    {
        Rigidbody bullet = Instantiate(BulletObject, TargetSpawn.transform.position, Quaternion.identity);
        bullet.AddRelativeForce(transform.forward * PowerForce);

        Debug.Log($"У {name} осталось - бесконечно выстрелов");
    }
}