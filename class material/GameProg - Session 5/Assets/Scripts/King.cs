using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : MonoBehaviour, IMove, IAttack
{
    Vector3 direction;
    [SerializeField] float speed = 1f;

    public bool isRunning;
    private Animator animator;

    void Awake() {
        animator = GetComponentInChildren<Animator>();
    }

    private void Update() {
        PositionUpdate();
    }

    public void PositionUpdate() {
        transform.position += direction * speed * Time.deltaTime;
    }

    public void SetDirection(Vector2 _direction) {
        direction.x = _direction.x;
        direction.y = _direction.y;

        animator.SetFloat("velocity", _direction.magnitude);
    }

    public void SetRotation(float xDirection) {
        if(xDirection < 0) {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        } else if(xDirection > 0) {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
