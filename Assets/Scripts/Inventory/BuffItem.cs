using UnityEngine;

public class BuffItem : Item
{
    public float duration = 5f;

    public override void Use(GameObject user)
    {
        Debug.Log($"{itemName} used. Buff applied for {duration} seconds");
    }
}
