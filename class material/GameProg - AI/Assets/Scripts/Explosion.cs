using System;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private int damage;

    private void Awake()
    {
        Destroy(gameObject, 0.5f);
    }
    internal void SetDamage(int damage)
    {
        this.damage = damage;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamageable damageable = collision.transform.GetComponent<IDamageable>();
        if (damageable is not null)
        {
            damageable.TakeDamage(damage);
        }
    }
}
