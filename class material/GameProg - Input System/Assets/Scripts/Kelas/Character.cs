using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{
    public UnityEvent<int> OnDamageTaken;
    public InputHandler inputHandler;

    int hp = 100;

    private void OnEnable()
    {
        OnDamageTaken.AddListener(ReduceHP);
    }

    public void TakeDamage()
    {
        OnDamageTaken.Invoke(100);
    }

    public void ReduceHP(int amount)
    {
        hp -= amount;
    }

    public void Interact()
    {
        Debug.Log($"Character is interacting");
    }
}
