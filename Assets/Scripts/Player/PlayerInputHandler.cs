using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] public InputActionsPlayer _playerInput;
    private Vector2 _moveInput;
    private Vector2 _moveInputSV;
    private Vector2 _moveCamera;

    public Vector2 MoveInput => _moveInput;
    public Vector2 MoveInputSV => _moveInputSV;
    public Vector2 CameraMove => _moveCamera;

    private void Awake()
    {
        _playerInput = new InputActionsPlayer();
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        _moveInput = ctx.ReadValue<Vector2>();
    }

    public void OnMoveSV(InputAction.CallbackContext ctx)
    {
        _moveInputSV = ctx.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext ctx)
    {
        _moveCamera = ctx.ReadValue<Vector2>();
    }
}
