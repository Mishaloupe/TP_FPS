using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [Header("Script")]
    [SerializeField] private PlayerInputHandler _inputHandler;

    [Header("Movement")]
    private float m_MoveSpeed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector2 move = _inputHandler.MoveInput; 

        Vector3 moveDirection = transform.forward * move.y + transform.right * move.x; 
        transform.position += moveDirection * (m_MoveSpeed * Time.deltaTime);
    }
}
