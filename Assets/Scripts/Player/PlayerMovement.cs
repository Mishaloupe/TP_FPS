using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Script")]
    [SerializeField] private PlayerInputHandler _inputHandler;
    [SerializeField] private PlayerCamera _playerCamera;

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
        if (_playerCamera._cameraType != "sideview")
        {
            Move();
        } else
        {
            this.gameObject.transform.rotation = Quaternion.identity;
            MoveSV();
        }



    }

    public void Move()
    {
        Vector2 move = _inputHandler.MoveInput;
        GameObject movepoint = this.gameObject;
        if (_playerCamera._cameraType != "topdown") {
            movepoint = _playerCamera._camerass[_playerCamera._cameraTypes.IndexOf(_playerCamera._cameraType)];
        } else { this.gameObject.transform.rotation = Quaternion.identity; }
            Vector3 moveDirection = movepoint.transform.forward * move.y + movepoint.transform.right * move.x;
        moveDirection.y = 0;
        transform.position += moveDirection * (m_MoveSpeed * Time.deltaTime);
    }

    public void MoveSV()
    {
        Vector2 moveSV = _inputHandler.MoveInputSV;
        GameObject activeCam = _playerCamera._camerass[_playerCamera._cameraTypes.IndexOf(_playerCamera._cameraType)];
        Vector3 moveDirection = activeCam.transform.forward * moveSV.y + activeCam.transform.right * moveSV.x;
        moveDirection.y = 0;
        transform.position += moveDirection * (m_MoveSpeed * Time.deltaTime);
    }
}
