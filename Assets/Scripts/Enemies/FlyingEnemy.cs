using UnityEngine;
using UnityEngine.AI;

public class FlyingEnemy : Enemy
{
    [SerializeField] private float attackRange = 1.5f;
    [SerializeField] private int attackDamage = 20;

    private Transform playerPos;
    private NavMeshAgent agent;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (playerPos == null) return;

        agent.SetDestination(playerPos.position);
        float distance = Vector3.Distance(transform.position, playerPos.position);

        if (distance <= attackRange)
        {
            Attack();
        }
    }
    public override void Attack()
    {

        Debug.Log($"Flying Enemy attack player with {attackDamage} damage");
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
    }
}
