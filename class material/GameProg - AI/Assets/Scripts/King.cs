using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class King : Entity
{
    public InputHandler inputHandler;

    //public Move move;
    //public Attack attack;
    private Dictionary<string, IAction> actions = new Dictionary<string, IAction>();

    private void Start()
    {
        actions.Add("move", new Move());
        actions["move"].Execute();

        actions.Add("attack", new Attack());
        actions["action"].Execute();
    }

    private void OnEnable()
    {
        inputHandler.SetDirection += SetDirection;
        inputHandler.Attack += Attack;
    }

    internal Health GetHealth()
    {
        return health;
    }
}
