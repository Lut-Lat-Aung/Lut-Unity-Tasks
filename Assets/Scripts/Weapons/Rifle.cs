using UnityEngine;

public class Rifle : Weapon
{
    protected override void Shoot()
    {
        Debug.Log($"Rifle is shooting. {Ammo} left");

        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogWarning("Rifle: bulletPrefab or firePoint not assigned!");
            return;
        }

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
