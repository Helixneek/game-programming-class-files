using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private IMove move;
    private IJump jump;

    private void Awake()
    {
        move = GetComponent<IMove>();
        jump = GetComponent<IJump>();
    }

    private void Update()
    {
        move.SetDirection(Input.GetAxisRaw("Horizontal"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump.Jump();
        }
    }
}
