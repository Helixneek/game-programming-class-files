using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float xDirection;
    [SerializeField] private float speed;
    [SerializeField] private float jumpHeight;

    private Rigidbody2D rb2d;

    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        PositionUpdate();
        InputHandler();
    }

    private void PositionUpdate() {
        transform.position += new Vector3(xDirection, 0, 0) * Time.deltaTime * speed;
    }

    private void InputHandler() {
        xDirection = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
    }

    private void Jump() {
        Vector2 jumpVelocity = new Vector2(rb2d.velocity.x, jumpHeight);

        rb2d.velocity = jumpVelocity;
    }
}
