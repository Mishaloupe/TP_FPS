using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] public InputActionsPlayer _playerInput;
    private Vector2 _moveInput;
    private Vector2 _moveCamera;
    private bool _attack;
    public Vector2 MoveInput => _moveInput;
    public Vector2 CameraMove => _moveCamera;
    public bool Attack => _attack;

    private void Awake()
    {
        _playerInput = new InputActionsPlayer();
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        _moveInput = ctx.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext ctx)
    {
        _moveCamera = ctx.ReadValue<Vector2>();
    }
    public void OnAttack(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            _attack = true;
        }
        if (ctx.canceled)
        {
            _attack = false;
        }
    }
}
