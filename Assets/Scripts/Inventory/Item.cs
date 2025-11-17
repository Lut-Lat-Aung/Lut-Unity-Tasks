using UnityEngine;

public abstract class Item : ScriptableObject
{
    public string itemName;
    public Sprite icon;

    public virtual void Use(GameObject user)
    {
        Debug.Log($"{itemName} used.");
    }
}
