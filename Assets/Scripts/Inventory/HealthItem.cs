using UnityEngine;

[CreateAssetMenu(menuName = "Items/HealthItem")]

public class HealthItem :  Item
{
    public int healAmount = 20;

    public override void Use(GameObject user)
    {
        Debug.Log($"{itemName} used. Healed player for {healAmount} HP");
    }
}
