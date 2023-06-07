using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputHandler", menuName = "Scriptable Objects/Input Handler")]
public class InputHandler : ScriptableObject, CustomInput.IGameplayActions
{
    private CustomInput customInput;
    public Action<float> SetDirection;
    public Action Attack;
    public Action Interact;

    public void OnAttack(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            Attack?.Invoke();
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        
    }

    public void OnSetDirection(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            SetDirection?.Invoke(context.ReadValue<Vector2>().x);
        }
    }
}
