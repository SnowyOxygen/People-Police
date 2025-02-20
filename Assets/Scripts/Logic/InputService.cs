using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputService : InputActions.IPlayerActions
{
    private InputActions _inputActions;

    public event Action OnResetEvent;
    public event Action<Vector2> OnMoveEvent;
    
    public InputService()
    {
        _inputActions = new InputActions();
        _inputActions.Player.AddCallbacks(this);
        _inputActions.Enable();
    }
    
    public void OnMove(InputAction.CallbackContext context)
    {
        OnMoveEvent?.Invoke(context.ReadValue<Vector2>());
    }

    public void OnLook(InputAction.CallbackContext context)
    {
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
    }

    public void OnJump(InputAction.CallbackContext context)
    {
    }

    public void OnPrevious(InputAction.CallbackContext context)
    {
    }

    public void OnNext(InputAction.CallbackContext context)
    {
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
    }

    public void OnTest(InputAction.CallbackContext context)
    {
        if(context.performed)
            OnResetEvent?.Invoke();
    }
}
