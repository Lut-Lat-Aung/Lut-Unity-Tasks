using UnityEngine;

public class AbilityTrigger : MonoBehaviour
{
    [SerializeField] private int damage = 0;
    [SerializeField] private int heal = 0;
    [SerializeField] private bool autoInteract = false;

    private void OnTriggerEnter(Collider other)
    {
        if (damage != 0)
        {
            var damageable = other.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(damage);
            }
        }

        if (heal != 0)
        {
            var healable = other.GetComponent<IHealable>();
            if (healable != null)
            {
                healable.Heal(heal);
            }
        }

        if (autoInteract)
        {
            var interactable = other.GetComponent<IInteractable>();
            var player = GetComponent<Player>();
            if (interactable != null && player != null)
            {
                interactable.Interact(player);
            }
        }
    }
}
