using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public GameObject inventoryPanel;
    public Transform itemGrid;
    public GameObject itemSlotPrefab;

    private void Start()
    {
        inventoryPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            bool active = inventoryPanel.activeSelf;
            inventoryPanel.SetActive(!active);

            if (!active) Refresh();
        }
    }

    public void Refresh()
    {
        foreach (Transform child in itemGrid)
            Destroy(child.gameObject);

        foreach (Item item in inventory.GetItems())
        {
            GameObject slot = Instantiate(itemSlotPrefab, itemGrid);
            InventorySlotUI ui = slot.GetComponent<InventorySlotUI>();
            ui.Init(item, inventory);
        }
    }
}
