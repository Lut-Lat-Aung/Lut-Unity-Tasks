using UnityEngine;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{
    public Image icon;
    public Item item;
    private Inventory inventory;

    public void Init(Item newItem, Inventory inv)
    {
        item = newItem;
        inventory = inv;
        icon.sprite = newItem.icon;
    }

    public void OnClick()
    {
        Debug.Log("Slot Clicked");
        inventory.Use(item, GameObject.Find("Player"));
    }
}
