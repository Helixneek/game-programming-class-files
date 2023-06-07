using System;
using UnityEngine;

[Serializable]
public class Health
{
    [SerializeField] private int currentHealth;
    private int maxHealth;

    public Health(int _maxHealth)
    {
        maxHealth = _maxHealth;
        currentHealth = maxHealth;
    }
    public int GetCurrentHealth()
    {
        return currentHealth;
    }
    public int GetMaxHealth()
    {
        return maxHealth;
    }
    public float GetPercentage()
    {
        return (float)currentHealth / (float)maxHealth;
    }
    internal void Reduce(int damage)
    {
        currentHealth = damage > currentHealth ? 0 : currentHealth - damage;
    }
    public void Gain(int value)
    {
        currentHealth = currentHealth + value > maxHealth ? maxHealth : currentHealth + value;
    }
}