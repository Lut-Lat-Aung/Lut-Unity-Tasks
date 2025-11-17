using UnityEngine;

public class WeaponItem : Item
{
    public int damageIncrease = 10;

    public override void Use(GameObject user)
    {
        Debug.Log($"{itemName} used. Damage increased by {damageIncrease}");
    }
}
