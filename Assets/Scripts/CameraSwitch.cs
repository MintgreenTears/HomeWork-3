using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;
    public Transform playerTransform;
    public Transform cameraPivot;

    private bool isFirstPerson = true;
    private bool isRotatingCamera = false;

    void Start()
    {
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isFirstPerson = !isFirstPerson;
            firstPersonCamera.enabled = isFirstPerson;
            thirdPersonCamera.enabled = !isFirstPerson;
        }

        if (Input.GetKeyDown(KeyCode.R) && !isFirstPerson)
        {
            ResetCamera();
        }

        if (!isFirstPerson)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isRotatingCamera = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                isRotatingCamera = false;
            }

            if (isRotatingCamera)
            {
                float mouseX = Input.GetAxis("Mouse X");
                float mouseY = Input.GetAxis("Mouse Y");

                playerTransform.Rotate(Vector3.up, mouseX);
                cameraPivot.Rotate(Vector3.right, -mouseY);
            }
        }
    }

    void ResetCamera()
    {
        thirdPersonCamera.transform.position = playerTransform.position + new Vector3(0, 1.5f, -3);
        thirdPersonCamera.transform.LookAt(playerTransform);
        cameraPivot.localRotation = Quaternion.identity;
    }
}