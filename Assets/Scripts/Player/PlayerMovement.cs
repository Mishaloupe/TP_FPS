using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Script")]
    [SerializeField] private PlayerInputHandler _inputHandler;

    [Header("Movement")]
    private Vector3 m_Position;
    private float m_MoveSpeed = 10.0f;

    [Header("Camera")]
    [SerializeField] private Camera _mainCamera;
    private float _xRotation = 0f;
    private float _mouseSensitivity = 25f;

    [SerializeField] Animator _animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;

        m_Position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Look();
    }

    public void Move()
    {
        Vector2 move = _inputHandler.MoveInput; 

        Vector3 moveDirection = transform.forward * move.y + transform.right * move.x; 
        transform.position += moveDirection * (m_MoveSpeed * Time.deltaTime);

        m_Position = transform.position;
    }

    public void Look()
    {
        Vector2 look = _inputHandler.CameraMove;

        transform.Rotate(Vector3.up * look.x * (_mouseSensitivity * Time.deltaTime));

        _xRotation -= look.y * (_mouseSensitivity * Time.deltaTime);
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        _mainCamera.transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
    }
}
