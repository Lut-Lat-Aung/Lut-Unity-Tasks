using UnityEngine;

public class TestInventoryUser : MonoBehaviour
{
    public Inventory inventory;

    public Item healthItem;
    public Item weaponItem;
    public Item keyItem;
    public Item buffItem;

    private void Start()
    {
        inventory.Add(healthItem);
        inventory.Add(weaponItem);
        inventory.Add(keyItem);
        inventory.Add(buffItem);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            inventory.Use(healthItem, gameObject);

        if (Input.GetKeyDown(KeyCode.W))
            inventory.Use(weaponItem, gameObject);

        if (Input.GetKeyDown(KeyCode.E))
            inventory.Use(keyItem, gameObject);

        if (Input.GetKeyDown(KeyCode.R))
            inventory.Use(buffItem, gameObject);
    }
}
