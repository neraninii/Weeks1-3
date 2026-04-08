using UnityEngine;

public class audiencemember : MonoBehaviour
{
    //setting speed variables
    public float speed = 1; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //creating movement on the x-axis
        Vector2 newPos = transform.position;
        newPos.y += speed; 
        transform.position = newPos; 

        //setting bounds to change direction 
        if (newPos.y > -4 || newPos.y < -6)
        {
            speed *= -1;
        }
        
    }
}
