using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour, IDamageable, IHealable, IMovable
{
    [Header("Stats")]
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private float moveSpeed = 5f;

    private int currentHealth;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        currentHealth = maxHealth;
    }

    // IDamageable
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Max(currentHealth, 0);
        Debug.Log($"Player took {amount} damage. HP: {currentHealth}/{maxHealth}");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // IHealable
    public void Heal(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);
        Debug.Log($"Player healed {amount}. HP: {currentHealth}/{maxHealth}");
    }

    // IMovable
    public void Move(Vector3 direction)
    {
        Vector3 velocity = direction.normalized * moveSpeed;
        rb.MovePosition(transform.position + velocity * Time.deltaTime);
    }

    private void Die()
    {
        Debug.Log("Player died.");
    }

    // Example of using IMovable in Update.
    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        if (dir.sqrMagnitude > 0.01f)
        {
            Move(dir);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInteract();
        }
    }

    private void TryInteract()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 2f))
        {
            var interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.Interact(this);
            }
        }
    }
}
