using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private King king;

    private void Awake() {
        king = GetComponent<King>();
    }

    private void Update() {
        king.SetDirection(new Vector2(
            Input.GetAxisRaw("Horizontal"), 
            Input.GetAxisRaw("Vertical"))
        );

        // if(Input.GetKeyDown(KeyCode.))
    }
}
