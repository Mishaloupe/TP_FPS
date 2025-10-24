using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] public InputActionsPlayer _playerInput;
    private Vector2 _moveInput;
    private Vector2 _moveCamera;
    private bool _jumping;
    private bool _shooting;

    public Vector2 MoveInput => _moveInput;
    public Vector2 CameraMove => _moveCamera;
    public bool Jumping => _jumping;
    public bool Shooting => _shooting;

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

    public void OnShoot(InputAction.CallbackContext ctx)
    {
        if (ctx.started) { _shooting = true; }
        if (ctx.canceled) { _shooting = false; }
    }
}
