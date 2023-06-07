using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Data", menuName ="Scriptable Object/Enemy Data")]
public class EnemyScriptable : ScriptableObject
{
    public string enemyName;
    public int maxHealth;
    public int attack;
    public int defense;
    
    public float getHealthPercentage(int currentHealth)
    {
        return (float)currentHealth / (float)maxHealth;
    }
}
