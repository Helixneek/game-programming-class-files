using System;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private int damage;
    [SerializeField] private GameObject explosionEffect;

    private Rigidbody2D Rigidbody2D;

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Explosion explosion = Instantiate(explosionEffect, transform.position, Quaternion.identity).GetComponent<Explosion>();
        explosion.SetDamage(damage);
        Destroy(gameObject);
    }
    public void SetVelocity(Vector2 direction)
    {
        Rigidbody2D.velocity = direction;
    }

    internal void SetDamage(int damage)
    {
        this.damage = damage;
    }
}
