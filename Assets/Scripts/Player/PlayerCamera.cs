using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private string _cameraType = "sideview";
    [SerializeField] private GameObject _camerasv;
    [SerializeField] private GameObject _cameratd;
    [SerializeField] private GameObject _camerafp;
    [SerializeField] private GameObject _cameratp;
    [SerializeField] private GameObject _cameracm;
    public List<string> _cameraTypes = new() { "sideview", "topdown", "FPS", "TPS" , "cinemachine"};
    public List<GameObject> _camerass;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _camerass = new() { _camerasv, _cameratd, _camerafp, _cameratp , _cameracm};
        _camerasv.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeCamera(string newCamera)
    {
        _camerass[_cameraTypes.IndexOf(_cameraType)].SetActive(false);
        _cameraType = newCamera;
        _camerass[_cameraTypes.IndexOf(newCamera)].SetActive(true);
    }
}
