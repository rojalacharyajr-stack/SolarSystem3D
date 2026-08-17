using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    static public GameObject target;  //determine the target of the camera


    void Start()
    {
        if(target == null)  
        {
            target = this.gameObject;  
            Debug.Log("Target is not set, setting it to the main camera");  
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target){
            transform.LookAt(target.transform);  //make the camera look at the target
        }
    }
}
