using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputHandler", menuName = "Scriptable Objects/Input Handler")]
public class InputHandler : ScriptableObject, InputSystem.IGameplayActions
{
    private InputSystem customInput;
    public Action Interact;
    public Action<Vector2> SetDirection;

    private void OnEnable()
    {
        if(customInput is null)
        {
            customInput = new InputSystem();
        }
        customInput.Gameplay.SetCallbacks(this);
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            Debug.Log($"Interacted");
            Interact?.Invoke();
        }
    }

    public void OnSetDirection(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Started)
        {
            Debug.Log($"Direction set");
            SetDirection?.Invoke(context.ReadValue<Vector2>());
        }
    }
}
