using UnityEngine;

public class PlayerPowerup : MonoBehaviour
{
    public float speed = 5f;
    public float damage = 10f;
    public bool hasShield = false;
    public float Shield = 10f;

    public Weapon currentWeapon;

    public void EquipTemporaryWeapon(Weapon newWeapon)
    {
        currentWeapon = newWeapon;
    }
}
