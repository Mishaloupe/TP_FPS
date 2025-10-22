using Unity.Cinemachine;
using UnityEngine;

public class CameraCinemachine : MonoBehaviour
{
    public CinemachineCamera tpsCam;
    public Transform target;
    public float sensitivity = 3f;
    public float yMin = -40f;
    public float yMax = 80f;

    float xRot, yRot;

    void Update()
    {
        Look();
    }

    public void Look()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        xRot += mouseX;
        yRot -= mouseY;
        yRot = Mathf.Clamp(yRot, yMin, yMax);

        target.rotation = Quaternion.Euler(0f, xRot, 0f);
        tpsCam.Follow.rotation = Quaternion.Euler(yRot, xRot, 0f);
    }
}