using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
  
    [SerializeField] private UnityEvent<Vector2> _onMove;
    public void OnMove(InputAction.CallbackContext context)
    {
        _onMove.Invoke(context.ReadValue<Vector2>());
    }
}
