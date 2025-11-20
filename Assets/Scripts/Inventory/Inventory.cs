using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> items = new List<Item>();

    public void Add(Item item)
    {
        items.Add(item);
        Debug.Log($"{item.itemName} added to inventory.");
    }

    public void Remove(Item item)
    {
        items.Remove(item);
        Debug.Log($"{item.itemName} removed from inventory.");
    }

    public void Use(Item item, GameObject user)
    {
        if (items.Contains(item))
        {
            item.Use(user);
        }
    }

    public List<Item> GetItems()
    {
        return items;
    }

}
