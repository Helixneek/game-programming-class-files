using UnityEngine;

public class Enemy : Entity
{
    [SerializeField] private EnemyScriptable enemyData;

    private void Start()
    {
        health = new Health(enemyData.maxHealth);
    }

    private void FixedUpdate()
    {
        PositionUpdate();
    }

    internal Health GetHealth()
    {
        return health;
    }
}
