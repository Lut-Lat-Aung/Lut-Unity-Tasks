using UnityEngine;

public class HealthPotion : MonoBehaviour, IInteractable, IHealable
{
    [SerializeField] private int healAmount = 25;

    // IInteractable
    public void Interact(Player player)
    {
        var healable = player as IHealable;
        if (healable != null)
        {
            healable.Heal(healAmount);
            Debug.Log($"Potion healed player for {healAmount}.");
            Destroy(gameObject); // consume the potion
        }
    }

    // IHealable
    public void Heal(int amount)
    {
        
    }
}
