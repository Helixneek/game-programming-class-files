using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal interface IMove {
    void SetDirection(Vector2 _direction);
    void PositionUpdate();
    void SetRotation(float xDirection);
}