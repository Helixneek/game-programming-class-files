using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Canon : MonoBehaviour, IAttack
{
    [SerializeField] private float speed;
    [SerializeField] private int damage;
    [SerializeField] private GameObject bomb;
    [SerializeField] private Transform bombAnchor;

    public UnityEvent OnAttack;

    private IEnumerator Start()
    {
        while (true)
        {
            Attack();
            yield return new WaitForSeconds(1);
        }
    }

    public void Attack()
    {
        Bomb _bomb = Instantiate(bomb, bombAnchor.position, Quaternion.identity).GetComponent<Bomb>();

        _bomb.SetVelocity(GetDirection() * speed);
        _bomb.SetDamage(damage);

        OnAttack.Invoke();
    }

    private Vector2 GetDirection()
    {
        Vector2 direction = new Vector2();
        direction.x = transform.rotation.eulerAngles.y == 0 ? 1 : -1;
        direction.y = 1;

        return direction;
    }
}
