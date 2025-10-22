using UnityEngine;

public class CameraTopdown : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _Camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Look();
    }

    public void Look()
    {
        Vector3 _playerPos = _player.transform.position;
        _playerPos.y += 25;
        _Camera.transform.position = _playerPos;
    }
}
