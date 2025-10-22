using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class CameraTPS : MonoBehaviour
{
    [SerializeField] private PlayerInputHandler _inputHandler;

    [Header("Camera")]
    [SerializeField] private GameObject _player;
    //[SerializeField] private Camera _mainCamera;
    [SerializeField] private GameObject _pivot;
    private float _xRotation = 0f;
    private float _yRotation = 0f;
    private float _mouseSensitivity = 25f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _inputHandler = _player.GetComponent<PlayerInputHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        Look();
        MoveCamera();
    }

    public void Look()
    {
        Vector2 look = _inputHandler.CameraMove;

        //_pivot.transform.Rotate(Vector3.up * look.x * (_mouseSensitivity * Time.deltaTime));

        _xRotation -= look.y * (_mouseSensitivity * Time.deltaTime);
        _yRotation += look.x * (_mouseSensitivity * Time.deltaTime);
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        _pivot.transform.localRotation = Quaternion.Euler(_xRotation, _yRotation, 0f);
    }

    public void MoveCamera()
    {
        Vector3 pPos = _player.transform.position;
        transform.position = new Vector3(pPos.x, pPos.y+2, pPos.z-4);
    }
}
