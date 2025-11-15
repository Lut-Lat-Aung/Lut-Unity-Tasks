using UnityEngine;

public abstract class Weapon : MonoBehaviour

{
    [SerializeField] private int damage = 50;
    [SerializeField] private float fireRate = 1.5f;
    [SerializeField] private int ammo = 10;

    [SerializeField] protected GameObject bulletPrefab;
    [SerializeField] protected Transform firePoint;

    private float lastFireTime;
    public void Fire()
    {

        if (Time.time < lastFireTime + fireRate)
        {
            return;
        }

        if (ammo <= 0)
        {
            Debug.Log($"{name}: Out of ammo!");
            return;
        }

        ammo--;
        lastFireTime = Time.time;

        Shoot();

    }


    protected abstract void Shoot();

    public void Reload()
    {
        ammo = 10;
        Debug.Log($"{name}: Reloaded. Ammo: {ammo}");
    }


    public int GetCurrentAmmo()
    {
        return ammo;
    }


    public int Damage => damage;
    public float FireRate => fireRate;

    public int Ammo => ammo;

}
