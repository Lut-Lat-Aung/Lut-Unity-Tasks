using UnityEngine;

public class Trap : MonoBehaviour, IDamageable
{
    [SerializeField] private int maxHealth = 30;
    private int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log($"Trap took {amount} damage. HP: {currentHealth}/{maxHealth}");

        if (currentHealth <= 0)
        {
            DestroyTrap();
        }
    }

    private void DestroyTrap()
    {
        Debug.Log("Trap destroyed.");
        Destroy(gameObject);
    }

    [SerializeField] private int damageToPlayer = 10;

    private void OnTriggerEnter(Collider other)
    {
        var damageable = other.GetComponent<IDamageable>();
        if (damageable != null && other.CompareTag("Player"))
        {
            damageable.TakeDamage(damageToPlayer);
        }
    }
}
