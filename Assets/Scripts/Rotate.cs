using UnityEngine;

public class Rotate : MonoBehaviour
{
   

    public Transform target;
    public int speed;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);

    }
}
