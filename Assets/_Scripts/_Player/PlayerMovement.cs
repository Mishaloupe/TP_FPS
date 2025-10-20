using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Script")]
    [SerializeField] private PlayerInputHandler _inputHandler;

    [Header("Movement")]
    private Vector3 m_Position; // pour la save on sait jamais
    private float m_MoveSpeed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        m_Position = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        Vector2 move = _inputHandler.MoveInput; 

        Vector3 moveDirection = transform.forward * move.y + transform.right * move.x; 
        transform.position += moveDirection * (m_MoveSpeed * Time.deltaTime);

        m_Position = transform.position;
    }
}
