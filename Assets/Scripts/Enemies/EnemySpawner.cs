using UnityEngine;

public enum EnemyType
{
    Melee,
    Ranged,
    Flying
}

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy meleeEnemyPrefab;
    [SerializeField] private Enemy rangedEnemyPrefab;
    [SerializeField] private Enemy flyingEnemyPrefab;

    [Header("Spawn Settings")]
    [SerializeField] private Transform[] spawnPoints;

    public Enemy SpawnEnemy(EnemyType type)
    {
        if (spawnPoints == null || spawnPoints.Length == 0)
        {
            Debug.LogWarning("No spawn points set on EnemySpawner!");
            return null;
        }

        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Enemy prefabToSpawn = null;

        switch (type)
        {
            case EnemyType.Melee:
                prefabToSpawn = meleeEnemyPrefab;
                break;
            case EnemyType.Ranged:
                prefabToSpawn = rangedEnemyPrefab;
                break;
            case EnemyType.Flying:
                prefabToSpawn = flyingEnemyPrefab;
                break;
        }

        if (prefabToSpawn == null)
        {
            Debug.LogWarning($"Prefab for {type} is not assigned on EnemySpawner!");
            return null;
        }

        Enemy enemyInstance = Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
        
        return enemyInstance;
    }

    public void SpawnAndAttack()
    {
        EnemyType randomType = (EnemyType)Random.Range(0, 3);
        Enemy enemy = SpawnEnemy(randomType);

        if (enemy != null)
        {
            enemy.Attack();       
            enemy.TakeDamage(30);
        }
    }
}
