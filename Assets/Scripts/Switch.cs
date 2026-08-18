using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject target;

    private void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("Target is not set, setting it to this object");
        }
    }

    private void OnMouseDown()
    {
        CameraController.target = target;
        Camera.main.fieldOfView = 20;
    }
}