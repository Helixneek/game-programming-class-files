using UnityEngine;
using UnityEngine.Events;

public class Entity : MonoBehaviour, IMove, IJump, IDamageable
{
    [SerializeField] protected float speed;
    [SerializeField] protected float jumpPower;
    [SerializeField] protected Health health;

    // To get shit immediately and have it be read-only (you can have set and get)
    //public Health Health => health;

    public UnityEvent OnJump;

    protected Vector3 direction;

    // components
    protected Rigidbody2D Rigidbody2D;

    protected void Awake()
    {
        direction = new Vector3();
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        Vector3 jumpVector = new Vector3(Rigidbody2D.velocity.x, jumpPower, 0);
        Rigidbody2D.velocity = jumpVector;

        OnJump.Invoke();
    }
    public void SetDirection(float direction)
    {
        this.direction.x = direction;

        SetOrientation(direction);
    }

    public void PositionUpdate()
    {
        transform.position += direction * Time.deltaTime * speed;
    }
    public void SetOrientation(float direction)
    {
        if (direction > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direction < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    public void TakeDamage(int damage)
    {
        health.Reduce(damage);
        //currentHp = damage > currentHp ? 0 : currentHp - damage;
    }

    public void DestroyEntity()
    {
        if(health.GetCurrentHealth() <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}