using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Data", menuName = "Scriptable Objects/Enemy Data")]
public class EnemyScriptable : ScriptableObject
{
    public new string name;
    public int maxHealth;
    public float speed;
}
