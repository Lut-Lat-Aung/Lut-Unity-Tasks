using UnityEngine;

public class RangedEnemy : Enemy
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float projectileSpeed = 10f;
    [SerializeField] private int projectileDamage = 15;


    private Transform playerTarget;

    void Start()
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
        if (p != null)
            playerTarget = p.transform;
    }


    public override void Attack()
    {
        if (projectilePrefab == null || firePoint == null)
        {
            Debug.LogWarning($"Ranged Enemy is missing projectilePrefab or firePoint!");
            return;
        }

        Vector3 dir = (playerTarget.position - firePoint.position).normalized;
        


        GameObject proj = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = proj.GetComponent<Rigidbody>();
        dir = Quaternion.Euler(90, 0, 0) * dir;

        if (rb != null)
        {
            rb.linearVelocity = dir * projectileSpeed;
        }

        Debug.Log($"Ranged Enemy fires a projectile deal {projectileDamage} damage.");
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
    }

}
