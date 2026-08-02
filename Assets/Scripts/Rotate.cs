using UnityEngine;

public class Rotate : MonoBehaviour
{
    //declaring variables to select the rotation target

    public Transform target;
    public int speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate around the first parameter transform, the second parameter is the axis of rotation, and the third parameter is the speed of rotation
        //target.transform.up:  second parameter is used to rotate around the y-axis of the target object
        //speed: third parameter is used to control the speed of rotation
        //Time.deltaTime: used to make the rotation frame rate independent, so that the rotation speed is consistent across different frame rates
        
         transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);

    }
}
