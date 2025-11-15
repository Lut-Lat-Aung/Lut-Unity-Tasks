using UnityEngine;

public class Pistol : Weapon
{
    protected override void Shoot()
    {
        Debug.Log($"Pistol is shooting. {Ammo} left");


        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogWarning("Pistol: bulletPrefab or firePoint not assigned!");
            return;
        }

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }

}
