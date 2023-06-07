using System;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    // Getting enemy scriptable data
    public EnemyScriptable enemyData;
    // Health
    [SerializeField] private int health;
    // Action to store a function, and it accepts those with the parameters specified
    public Action<float> OnDamageTaken;

    private void Start()
    {
        health = enemyData.maxHealth;
    }

    private void Update()
    {
        // Use this for testing
        // Updating the health bar on every frame is not ideal
        //OnDamageTaken.Invoke(enemyData.getHealthPercentage(health));

        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        }
    }

    public void TakeDamage(int damage)
    {
        health = health > damage ? health - damage : 0;

        // Invoke memerlukan parameter sesuai variabel
        OnDamageTaken.Invoke(enemyData.getHealthPercentage(health));
    }
}
