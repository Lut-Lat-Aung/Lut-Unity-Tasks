using UnityEngine;

public class MeleeEnemy : Enemy
{
    [SerializeField] private float attackRange = 1.5f;
    [SerializeField] private int attackDamage = 20;

    public override void Attack()
    {
        // I can't think of an attack patten for Melee. I left this with Debug log.
        Debug.Log($"Melee deal {attackDamage} damage within {attackRange} units.");
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
    }
}
