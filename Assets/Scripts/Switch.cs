using UnityEngine;

public class Switch : MonoBehaviour
{

    public GameObject target;  
        if(target==null)  
        {
            target =this.gameObject;  
            Debug.Log("Target is not set, setting it to this object");  
        }
    }

     private void OnMouseDown()  // c
    {
        CameraController.target = target;  
        Camera.main.fieldOfView =20; 
        
       
    }
}
