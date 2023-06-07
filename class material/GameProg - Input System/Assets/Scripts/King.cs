using UnityEngine;
using UnityEngine.Events;

public class King : Entity
{
    private void Update()
    {
        PositionUpdate();
    }
    internal Health GetHealth()
    {
        return health;
    }
}
