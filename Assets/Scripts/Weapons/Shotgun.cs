using UnityEngine;

public class Shotgun : Weapon
{
    protected override void Shoot()
    {
        Debug.Log($"Shotgun is shooting. {Ammo} left");

        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogWarning("Shotgun: bulletPrefab or firePoint not assigned!");
            return;
        }

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);


    }
}
