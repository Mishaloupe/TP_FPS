using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class CameraTPS : MonoBehaviour
{
    [SerializeField] private PlayerInputHandler _inputHandler;

    [Header("Camera")]
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _pivot;
    private float _xRotation = 0f;
    private float _yRotation = 0f;
    private float _mouseSensitivity = 25f;
    [SerializeField] private float _distanceFromPivot = 4f;
    [SerializeField] private Vector2 _pitchLimits = new Vector2(-30f, 60f);

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

    private void Look()
    {
        Vector2 look = _inputHandler.CameraMove;

        _yRotation += look.x * _mouseSensitivity * Time.deltaTime;
        _xRotation -= look.y * _mouseSensitivity * Time.deltaTime;
        _xRotation = Mathf.Clamp(_xRotation, _pitchLimits.x, _pitchLimits.y);

        _pivot.rotation = Quaternion.Euler(_xRotation, _yRotation, 0f);
    }

    private void MoveCamera()
    {
        Vector3 targetPosition = _pivot.position - _pivot.forward * _distanceFromPivot;
        transform.position = targetPosition;
        transform.LookAt(_pivot);
    }
}
