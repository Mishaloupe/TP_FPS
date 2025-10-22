using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private string _cameraType = "cinemachine";
    [SerializeField] private GameObject _camerasv;
    [SerializeField] private GameObject _cameratd;
    [SerializeField] private GameObject _camerafp;
    [SerializeField] private GameObject _cameratp;
    [SerializeField] private GameObject _cameracm;
    [SerializeField] private GameObject _cinemachineBrain;
    public List<string> _cameraTypes = new() { "sideview", "topdown", "FPS", "TPS" , "cinemachine"};
    public List<GameObject> _camerass;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _camerass = new() { _camerasv, _cameratd, _camerafp, _cameratp , _cameracm};
        changeCamera("cinemachine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeCamera(string newCamera)
    {
        if (newCamera == "cinemachine") { _cinemachineBrain.SetActive(true); } else { _cinemachineBrain.SetActive(false); }
            _camerass[_cameraTypes.IndexOf(_cameraType)].SetActive(false);
        _cameraType = newCamera;
        _camerass[_cameraTypes.IndexOf(newCamera)].SetActive(true);
    }
}
