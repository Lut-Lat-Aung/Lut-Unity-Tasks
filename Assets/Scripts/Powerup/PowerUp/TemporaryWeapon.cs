using UnityEngine;

public class TemporaryWeapon : IPowerUp
{
    private Weapon weaponPrefab;
    private Weapon spawnedWeapon;

    public TemporaryWeapon(Weapon prefab)
    {
        weaponPrefab = prefab;
    }

    public void Apply(PlayerPowerup player)
    {
        spawnedWeapon = GameObject.Instantiate(weaponPrefab);
        player.EquipTemporaryWeapon(spawnedWeapon);
        Debug.Log("Temporary weapon equipped!");
    }

    public void Remove(PlayerPowerup player)
    {
        GameObject.Destroy(spawnedWeapon.gameObject);
        Debug.Log("Temporary weapon removed!");
    }
}
