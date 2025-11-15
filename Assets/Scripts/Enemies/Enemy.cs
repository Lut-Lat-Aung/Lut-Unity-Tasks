using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected int health = 100;
    [SerializeField] protected float speed = 3f;

    public int Health => health;
    public float Speed => speed;

    public abstract void Attack();

    public virtual void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log($"{name} took {amount} damage. Remaining HP: {health}");

        if (health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log($"{name} died.");
        Destroy(gameObject);
    }
}
