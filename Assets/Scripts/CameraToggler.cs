using UnityEngine;

public class CameraToggler : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject topViewCamera;

    void Start()
    {
        // Set the initial state when the game starts
        mainCamera.SetActive(true);
        topViewCamera.SetActive(false);
    }

    void Update()
    {
        // Toggle when the "C" key is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleCameras();
        }
    }

    void ToggleCameras()
    {
        // Invert the active state of both cameras
        mainCamera.SetActive(!mainCamera.activeSelf);
        topViewCamera.SetActive(!topViewCamera.activeSelf);
    }
}
