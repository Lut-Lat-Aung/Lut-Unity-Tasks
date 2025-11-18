using UnityEngine;

[CreateAssetMenu(menuName = "Items/KeyItem")]
public class KeyItem : Item
{
    public string doorID;

    public override void Use(GameObject user)
    {
        Debug.Log($"{itemName} used. Opens door: {doorID}");
    }
}
