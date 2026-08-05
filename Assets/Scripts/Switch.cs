using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject target;  //declare a game object variable to hold the target of the camera

    void Start()
    {
        if(target==null)  //if the target is not set, log a message to the console
        {
            target =this.gameObject;  //set the target to this object
            Debug.Log("Target is not set, setting it to this object");  //log a message to the console
        }
    }

     private void OnMouseDown()  // called when the mouse is clicked on the object
    {
        CameraController.target = target;  //set the target of the camera to the target of this object
        Camera.main.fieldOfView =20; //set the field of view of the camera to 20
        Debug.Log("You clicked " + target.name); //log the name of the target object to the console
       
    }
}
