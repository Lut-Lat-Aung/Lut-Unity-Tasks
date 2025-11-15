using UnityEngine;

public class FlyingEnemy : Enemy
{
    [SerializeField] private float attackRange = 1.5f;
    [SerializeField] private int attackDamage = 20;

    private Transform target;

    private void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
            target = playerObj.transform;
    }

    public override void Attack()
    {
        if (target == null)
        {
            Debug.Log($"{name} (Flying) has no target to attack.");
            return;
        }

        transform.position += target.position * speed * Time.deltaTime;

        Debug.Log($"Flying Enemy attack player with {attackDamage} damage");
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
    }
}
