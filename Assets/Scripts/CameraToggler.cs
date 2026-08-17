using UnityEngine;

public class CameraToggler : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject topViewCamera;

    void Start()
    {
        
        mainCamera.SetActive(true);
        topViewCamera.SetActive(false);
    }

    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleCameras();
        }
    }

    void ToggleCameras()
    {
        
        mainCamera.SetActive(!mainCamera.activeSelf);
        topViewCamera.SetActive(!topViewCamera.activeSelf);
    }
}
