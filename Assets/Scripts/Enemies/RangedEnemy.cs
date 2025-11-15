using UnityEngine;

public class RangedEnemy : Enemy
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float projectileSpeed = 10f;
    [SerializeField] private int projectileDamage = 15;

    public override void Attack()
    {
        if (projectilePrefab == null || firePoint == null)
        {
            Debug.LogWarning($"Ranged Enemy is missing projectilePrefab or firePoint!");
            return;
        }

        GameObject proj = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = proj.GetComponent<Rigidbody>();

        // this is for making the projectile shoot
        if (rb != null)
        {
            rb.linearVelocity = firePoint.up * projectileSpeed;
        }

        Debug.Log($"Ranged Enemy fires a projectile deal {projectileDamage} damage.");
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
    }

}
